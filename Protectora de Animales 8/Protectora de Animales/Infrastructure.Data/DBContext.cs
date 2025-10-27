using Domain;
using Domain.History;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace Infrastructure.Data
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<House> Houses { get; set; }
        public DbSet<Sighting> Sightings { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<MedicalCheckUp> MedicalCheckUps { get; set; }
        public DbSet<AnimalResponsibleHistory> AnimalResponsibleHistories { get; set; }

        internal DBContext()
        {
            Database.EnsureCreated();
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { if (!optionsBuilder.IsConfigured) { var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build(); string connectionString = configuration.GetConnectionString("DefaultConnection"); optionsBuilder.UseSqlServer(connectionString); } }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //----- USERS -----
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SurName)
                   .IsRequired()
                   .HasMaxLength(100);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasConversion<string>();

                entity.Property(e => e.UserStatus)
                    .IsRequired()
                    .HasDefaultValue(UserStatus.Active)
                    .HasConversion<string>();
                // Relación uno a uno entre User y House
                entity.HasOne<House>()
                    .WithOne()
                    .HasForeignKey<House>(h => h.UserId);
                //seeding data
                entity.HasData(

                 new User("user-1", "UTN", "Rosario", "12345678", UserType.Admin, "utn", "123", UserStatus.Active),

                // Adoptantes
                new User("user-2", "Camila", "Stella", "87654321", UserType.Adoptante, "cami", "123", UserStatus.Active),
                new User("user-5", "Martín", "González", "33445566", UserType.Adoptante, "martin", "123", UserStatus.Active),
                new User("user-6", "Laura", "Fernández", "44556677", UserType.Adoptante, "laura", "123", UserStatus.Active),
                new User("user-7", "Diego", "Rodríguez", "55667788", UserType.Adoptante, "diego", "123", UserStatus.Active),
                new User("user-8", "Sofía", "López", "66778899", UserType.Adoptante, "sofia", "123", UserStatus.Active),
                new User("user-9", "Valentina", "Moreno", "77889900", UserType.Adoptante, "valen", "123", UserStatus.Active),
                new User("user-10", "Andrés", "Pérez", "88990011", UserType.Adoptante, "andres", "123", UserStatus.Active),

                // Voluntarios
                new User("user-3", "Ignacio", "Esteves", "44180117", UserType.Voluntario, "nacho", "123", UserStatus.Active),
                new User("user-11", "Lucía", "Benítez", "99112233", UserType.Voluntario, "lucia", "123", UserStatus.Active),
                new User("user-12", "Pedro", "Luna", "99223344", UserType.Voluntario, "pedro", "123", UserStatus.Active),
                new User("user-13", "Marta", "Salas", "99334455", UserType.Voluntario, "marta", "123", UserStatus.Active),

                // Tránsitos
                new User("user-4", "Nicolás", "Salerno", "11223344", UserType.Transito, "niko", "123", UserStatus.Active),
                new User("user-14", "Julieta", "Rossi", "22334455", UserType.Transito, "juli", "123", UserStatus.Active),
                new User("user-15", "Federico", "Torres", "33445577", UserType.Transito, "fede", "123", UserStatus.Active),
                new User("user-16", "Carla", "Mendez", "44557788", UserType.Transito, "carla", "123", UserStatus.Active));
            });


            //----- ANIMAL -----
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Species)
                    .IsRequired()
                    .HasConversion<string>();

                entity.Property(e => e.BirthDate)
                    .IsRequired();

                entity.Property(e => e.AnimalState)
                    .IsRequired()
                    .HasConversion<string>();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UserId);

                entity.Navigation(e => e.User);

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .IsRequired(false);

                //seeding data (Adoptado solo si User es Adoptante; BajoCuidado si no; ARevisar si sin User)
                entity.HasData(
                   new Animal("1", "Firulais", Animal.SpeciesEn.Perro, new DateTime(2018, 5, 20), null, Animal.AnimalStateEn.ARevisar,
                   "Perro mestizo de tamaño mediano, pelaje corto marrón con pecho blanco. Muy amistoso con las personas y tranquilo en los paseos."),

                    new Animal("2", "Miau", Animal.SpeciesEn.Gato, new DateTime(2020, 3, 15), "user-5", Animal.AnimalStateEn.Adoptado,
                        "Gato adulto de color gris atigrado, ojos verdes y carácter dulce. Se adaptó muy bien a su nuevo hogar."),

                    new Animal("3", "Bunny", Animal.SpeciesEn.Conejo, new DateTime(2021, 7, 10), null, Animal.AnimalStateEn.ARevisar,
                        "Conejo blanco con manchas grises, muy curioso y dócil. Le gusta saltar y explorar los rincones del lugar."),

                    new Animal("4", "Lola", Animal.SpeciesEn.Gato, new DateTime(2019, 2, 5), "user-4", Animal.AnimalStateEn.BajoCuidado,
                        "Gata de pelo negro brillante, muy observadora y tranquila. Fue rescatada de la calle y actualmente está en recuperación."),

                    new Animal("5", "Rex", Animal.SpeciesEn.Perro, new DateTime(2017, 11, 30), "user-2", Animal.AnimalStateEn.Adoptado,
                        "Perro grande de color beige con orejas caídas. Protector, paciente con niños y muy fiel a su adoptante."),

                    new Animal("6", "Coco", Animal.SpeciesEn.Conejo, new DateTime(2022, 1, 25), null, Animal.AnimalStateEn.ARevisar,
                        "Conejo marrón oscuro de orejas largas, enérgico y juguetón. Se asusta fácilmente pero es muy curioso."),

                    new Animal("7", "Pepi", Animal.SpeciesEn.Pajaro, new DateTime(2016, 8, 18), "user-3", Animal.AnimalStateEn.BajoCuidado,
                        "Canario macho de plumaje amarillo intenso. Alegre, canta todos los días y se muestra muy sociable."),

                    new Animal("8", "Toby", Animal.SpeciesEn.Perro, new DateTime(2019, 10, 12), "user-14", Animal.AnimalStateEn.BajoCuidado,
                        "Perro mestizo color negro con patas blancas. Fue rescatado del abandono, ahora está recuperando peso y confianza."),

                    new Animal("9", "Luna", Animal.SpeciesEn.Perro, new DateTime(2020, 4, 8), null, Animal.AnimalStateEn.ARevisar,
                        "Cachorra de tamaño mediano, pelaje dorado y ojos claros. Muy activa y juguetona, ideal para una familia con espacio."),

                    new Animal("10", "Rocky", Animal.SpeciesEn.Perro, new DateTime(2017, 6, 20), "user-7", Animal.AnimalStateEn.Adoptado,
                        "Perro de pelaje oscuro, fuerte y leal. Se muestra protector y siempre atento a su entorno."),

                    new Animal("11", "Simón", Animal.SpeciesEn.Gato, new DateTime(2021, 2, 14), "user-12", Animal.AnimalStateEn.BajoCuidado,
                        "Gato de pelo blanco y gris, ojos celestes. Muy mimoso y busca compañía humana constantemente."),

                    new Animal("12", "Misha", Animal.SpeciesEn.Gato, new DateTime(2022, 11, 1), null, Animal.AnimalStateEn.ARevisar,
                        "Gatita joven de color marrón claro con manchas blancas. Un poco tímida al principio, pero muy cariñosa cuando toma confianza."),

                    new Animal("13", "Tigra", Animal.SpeciesEn.Gato, new DateTime(2019, 7, 22), "user-9", Animal.AnimalStateEn.Adoptado,
                        "Gata atigrada de pelaje dorado. Activa, curiosa y siempre lista para jugar."),

                    new Animal("14", "Nieve", Animal.SpeciesEn.Conejo, new DateTime(2023, 3, 15), null, Animal.AnimalStateEn.ARevisar,
                        "Coneja completamente blanca, de pelaje suave. Tranquila, le gusta estar en brazos y es muy limpia."),

                    new Animal("15", "Choco", Animal.SpeciesEn.Conejo, new DateTime(2022, 5, 5), "user-15", Animal.AnimalStateEn.BajoCuidado,
                        "Conejo marrón claro de orejas cortas. Muy sociable con otros conejos y disfruta de la compañía humana."),

                    new Animal("16", "Lili", Animal.SpeciesEn.Conejo, new DateTime(2021, 9, 10), "user-6", Animal.AnimalStateEn.Adoptado,
                        "Coneja de color gris claro, muy sociable y tranquila. Le encanta recibir caricias y estar al aire libre."),

                    new Animal("17", "Azul", Animal.SpeciesEn.Pajaro, new DateTime(2020, 12, 25), "user-13", Animal.AnimalStateEn.BajoCuidado,
                        "Pájaro pequeño de tonos azules y verdes. Tiene un canto melodioso y disfruta del contacto visual con las personas."),

                    new Animal("18", "Sol", Animal.SpeciesEn.Pajaro, new DateTime(2023, 1, 18), null, Animal.AnimalStateEn.ARevisar,
                        "Polluelo color amarillo claro, encontrado en la vía pública. Está en observación hasta completar su desarrollo."),

                    new Animal("19", "Kiwi", Animal.SpeciesEn.Pajaro, new DateTime(2022, 4, 2), "user-11", Animal.AnimalStateEn.Adoptado,
                        "Pájaro pequeño de plumaje verde brillante, recuperado tras una lesión en el ala. Ahora vuela y canta normalmente.")
                    );

            });

            //----- HOUSE -----
            modelBuilder.Entity<House>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .IsRequired();

                entity.Property(e => e.Address)
                    .IsRequired();

                entity.Property(e => e.AddressNumber)
                    .IsRequired();

                entity.Property(e => e.Capacity)
                   .IsRequired();

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId);

                entity.HasData(
                    new House("house-1", "user-4", "Zeballos", 1341, 2),
                    new House("house-2", "user-14", "San Martín", 550, 3),
                    new House("house-3", "user-15", "Mitre", 200, 1),
                    new House("house-4", "user-16", "Dorrego", 900, 2)
                        );
            });
            //----- SIGHTING -----
            modelBuilder.Entity<Sighting>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.SightingAddressName)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.SightingAddressNumber)
                    .IsRequired();
                entity.Property(e => e.SightingDateTime)
                    .IsRequired();
                entity.Property(e => e.SightingDescription)
                    .IsRequired()
                    .HasMaxLength(300);
                entity.Property(e => e.Sightingstate)
                    .IsRequired();
                entity.HasData(
     new Sighting
     {
         Id = "s1",
         SightingAddressName = "Calle Falsa",
         SightingAddressNumber = "123",
         SightingDateTime = new DateTime(2025, 9, 25, 10, 30, 0),
         SightingDescription = "Avisté un perro corriendo solo",
         Sightingstate = Sighting.SightingState.Nuevo
     },
     new Sighting
     {
         Id = "s2",
         SightingAddressName = "Av. Libertad",
         SightingAddressNumber = "456",
         SightingDateTime = new DateTime(2025, 9, 24, 14, 0, 0),
         SightingDescription = "Gato atrapado en un árbol, unos pibes le estaban tirando piedras, los cagué a trompadas pero no pude bajar al gato del árbol",
         Sightingstate = Sighting.SightingState.Nuevo
     },
     new Sighting
     {
         Id = "s3",
         SightingAddressName = "Plaza Central",
         SightingAddressNumber = "10",
         SightingDateTime = new DateTime(2025, 9, 23, 9, 15, 0),
         SightingDescription = "Conejo perdido cerca del parque",
         Sightingstate = Sighting.SightingState.Nuevo
     },
     new Sighting
     {
         Id = "s4",
         SightingAddressName = "Barrio Norte",
         SightingAddressNumber = "2345",
         SightingDateTime = new DateTime(2025, 9, 22, 18, 45, 0),
         SightingDescription = "Se ve un pájaro herido",
         Sightingstate = Sighting.SightingState.Nuevo
     },
     new Sighting
     {
         Id = "s5",
         SightingAddressName = "Ruta 5",
         SightingAddressNumber = "2000",
         SightingDateTime = new DateTime(2025, 9, 21, 12, 0, 0),
         SightingDescription = "Avistamiento de perro callejero al borde de la ruta, pueden ser más de uno, pareciese tener crías",
         Sightingstate = Sighting.SightingState.Nuevo
     },

     new Sighting
     {
         Id = "s6",
         SightingAddressName = "Av. San Juan",
         SightingAddressNumber = "987",
         SightingDateTime = new DateTime(2025, 10, 1, 17, 0, 0),
         SightingDescription = "Perro negro con collar rojo caminando solo.",
         Sightingstate = Sighting.SightingState.Nuevo
     },
     new Sighting
     {
        Id = "s7",
        SightingAddressName = "Parque Sur",
        SightingAddressNumber = "45",
        SightingDateTime = new DateTime(2025, 10, 10, 8, 30, 0),
        SightingDescription = "Gato blanco escondido entre arbustos, parece asustado.",
        Sightingstate = Sighting.SightingState.Nuevo
     }
 );
            });

            modelBuilder.Entity<MedicalCheckUp>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnimalId)
                    .IsRequired();

                entity.HasOne(e => e.Animal)
                    .WithMany()
                    .HasForeignKey(e => e.AnimalId);

                entity.Property(e => e.CheckUpDate)
                    .IsRequired();

                entity.Property(e => e.Observation)
                    .IsRequired();

                entity.Ignore("UserId"); //ef keeps creating a column for UserId otherwise

                entity.HasData(
                new MedicalCheckUp(
                    "mc-1",
                    new DateTime(2024, 11, 15, 17, 45, 0),
                    "Control de rutina. Vacunas al día. Estado general excelente.",
                    "7"
                ),
                new MedicalCheckUp(
                    "mc-2",
                    new DateTime(2024, 10, 20, 17, 45, 0),
                    "Revisión post-adopción. El animal se ha adaptado bien. Se recomienda seguimiento en 3 meses.",
                    "5"
                ),
                new MedicalCheckUp(
                    "mc-3",
                    new DateTime(2024, 12, 5, 17, 45, 0),
                    "Desparasitación realizada. Peso adecuado para su edad. Continuar con alimentación actual.",
                    "4"
                ),
                new MedicalCheckUp(
                    "mc-4",
                    new DateTime(2024, 9, 10, 17, 45, 0),
                    "Control pre-adopción. Animal en condiciones óptimas para ser adoptado.",
                    "1"
                ),
                new MedicalCheckUp(
                    "mc-5",
                    new DateTime(2024, 8, 25, 17, 45, 0),
                    "Revisión dental. Se detectó sarro leve. Se realizó limpieza. Buen estado general.",
                    "2"
                ),
                new MedicalCheckUp("mc-6", 
                new DateTime(2024, 11, 30, 17, 45, 0),
                "Vacunación completa, leve sobrepeso.", 
                "8"
                ),
                new MedicalCheckUp("mc-7", 
                new DateTime(2024, 12, 12, 17, 45, 0), 
                "Chequeo general, sin anomalías.",
                "10"
                ),
                new MedicalCheckUp("mc-8",
                new DateTime(2024, 9, 5, 17, 45, 0 ), 
                "Tratamiento de pulgas realizado.",
                "11"
                ),
                new MedicalCheckUp("mc-9",
                new DateTime(2025, 1, 3, 17, 45, 0), 
                "Control rutinario," +
                " en excelente estado.", 
                "13"
                ),
                new MedicalCheckUp("mc-10",
                new DateTime(2024, 10, 21, 14,0,0), 
                "Revisión dental, " +
                "sin problemas.",
                "16"
                ));
            });

            modelBuilder.Entity<Adoption>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdoptionRequestDate)
                    .IsRequired();

                entity.Property(e => e.AdoptionResponseDate);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasConversion<string>()
                    .HasDefaultValue(AdoptionStateEn.Pendiente);

                entity.Property(e => e.AnimalId)
                   .IsRequired();

                entity.HasOne(e => e.Animal)
                    .WithMany()
                    .HasForeignKey(e => e.AnimalId);

                entity.Property(e => e.UserId)
                   .IsRequired();

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId);

                // seeding data
                entity.HasData(
        new Adoption(
            "adoption-1",
            "1",  // Firulais
            "user-2",  // Camila
            new DateTime(2024, 9, 15),
            AdoptionStateEn.Pendiente,
            "Interesada en adoptar a Firulais. Tengo experiencia con perros."
        ),
        new Adoption(
            "adoption-2",
            "2",  // Miau
            "user-5",  // Martín
            new DateTime(2024, 10, 5),
            AdoptionStateEn.Aprobada,
            "Solicitud aprobada. El gato ya se encuentra en su nuevo hogar."
        )
        {
            AdoptionResponseDate = new DateTime(2024, 10, 8)
        },
        new Adoption(
            "adoption-3",
            "3",  // Bunny
            "user-6",  // Laura
            new DateTime(2024, 10, 12),
            AdoptionStateEn.Rechazada,
            "No cuenta con espacio adecuado para conejos."
        )
        {
            AdoptionResponseDate = new DateTime(2024, 10, 14)
        },
        new Adoption(
            "adoption-4",
            "6",  // Coco
            "user-7",  // Diego
            new DateTime(2024, 10, 18),
            AdoptionStateEn.Pendiente,
            "Familia con niños pequeños, buscan un conejo tranquilo."
        ),
        new Adoption(
            "adoption-5",
            "1",  // Firulais (otra solicitud)
            "user-8",  // Sofía
            new DateTime(2024, 10, 20),
            AdoptionStateEn.Pendiente,
            "Vivo sola y trabajo desde casa. Puedo darle mucho tiempo y atención."
        ),
        new Adoption(
            "adoption-6",
            "2",  // Miau (solicitud anterior)
            "user-2",  // Camila
            new DateTime(2024, 9, 1),
            AdoptionStateEn.Rechazada,
            "Primera solicitud rechazada por falta de documentación."
        )
        {
            AdoptionResponseDate = new DateTime(2024, 9, 3)
        },
            new Adoption(
                "adoption-7"
                , "9", 
                "user-9", 
                new DateTime(2024, 11, 10), 
                AdoptionStateEn.Pendiente, 
                "Cree tener espacio adecuado."),
            new Adoption(
                "adoption-8",
                "10", 
                "user-10", 
                new DateTime(2024, 10, 25), AdoptionStateEn.Aprobada, 
                "Solicitud aprobada tras verificación.")
            { AdoptionResponseDate = new DateTime(2024, 10, 28) },
            new Adoption("adoption-9",
            "14",
            "user-6", 
            new DateTime(2024, 12, 2), 
            AdoptionStateEn.Pendiente, 
            "Estoy interesada en cuidar a Nieve, somos una familia muy cariñosa."),
            new Adoption("adoption-10", 
            "17", 
            "user-7", 
            new DateTime(2025, 1, 10),
            AdoptionStateEn.Rechazada,
            "El hogar no cumple las condiciones  necesarias para acoger aves.")
            { AdoptionResponseDate = new DateTime(2025, 1, 15) }
            );


            });

            //----- ANIMAL RESPONSIBLE HISTORY -----
            modelBuilder.Entity<AnimalResponsibleHistory>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AssignedDate)
                    .IsRequired();

                entity.Property(e => e.ResponsibleId)
                    .IsRequired();

                entity.HasOne(e => e.Responsible)
                    .WithMany()
                    .HasForeignKey(e => e.ResponsibleId);

                entity.Property(e => e.AnimalId)
                    .IsRequired();

                entity.HasOne(e => e.Animal)
                    .WithMany()
                    .HasForeignKey(e => e.AnimalId);

                // Seeding data con múltiples adopciones para algunos animales
                entity.HasData(
                    // Miau (Animal "2")
                    new AnimalResponsibleHistory("arh-1", new DateTime(2023, 12, 15, 14,35, 0), "user-2", "2"),
                    new AnimalResponsibleHistory("arh-2", new DateTime(2024, 3, 20, 10, 45, 0), "user-6", "2"),
                    new AnimalResponsibleHistory("arh-3", new DateTime(2024, 10, 8, 17,45,0), "user-5", "2"),

                    // Rex (Animal "5")
                    new AnimalResponsibleHistory("arh-4", new DateTime(2024, 2, 10, 15, 45, 0), "user-7", "5"),
                    new AnimalResponsibleHistory("arh-5", new DateTime(2024, 7, 20, 17,46, 0), "user-2", "5"),

                    // Lola (Animal "4")
                    new AnimalResponsibleHistory("arh-6", new DateTime(2024, 4, 5, 16,0,0), "user-3", "4"),
                    new AnimalResponsibleHistory("arh-7", new DateTime(2024, 6, 12, 13, 15, 0), "user-8", "4"),
                    new AnimalResponsibleHistory("arh-8", new DateTime(2024, 8, 15, 12, 45,0), "user-4", "4"),

                    // Pepi (Animal "7")
                    new AnimalResponsibleHistory("arh-9", new DateTime(2024, 1, 25,14,10,0), "user-6", "7"),
                    new AnimalResponsibleHistory("arh-10", new DateTime(2024, 9, 10,15,35,0), "user-3", "7"),

                    // Firulais (Animal "1")
                    new AnimalResponsibleHistory("arh-11", new DateTime(2023, 8, 10,16,15,0), "user-5", "1"),
                    new AnimalResponsibleHistory("arh-12", new DateTime(2024, 1, 15,14,20,0), "user-8", "1"),

                    // Bunny (Animal "3")
                    new AnimalResponsibleHistory("arh-13", new DateTime(2024, 5, 8, 17,10,0), "user-7", "3"),
                    new AnimalResponsibleHistory("arh-14", new DateTime(2024, 2, 12, 13,45,0), "user-14", "8"),
                    new AnimalResponsibleHistory("arh-15", new DateTime(2024, 8, 25, 16,10,0), "user-15", "15"),
                    new AnimalResponsibleHistory("arh-16", new DateTime(2024, 9, 18, 18,15,0), "user-16", "10"),
                    new AnimalResponsibleHistory("arh-17", new DateTime(2024, 10, 2, 14, 10, 0), "user-11", "17"),
                    new AnimalResponsibleHistory("arh-18", new DateTime(2025, 2, 10, 15,45,0), "user-12", "11"),
                    new AnimalResponsibleHistory("arh-19", new DateTime(2025, 3, 5,17, 45, 0), "user-6", "16")
                );
            });
        }
    }
}