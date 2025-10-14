using Domain;
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
        public DbSet<MedicalCheckUp> MedicalCheckUps { get; set; }

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
                new User("user-2", "Camila", "Stella", "87654321", UserType.Adoptante, "cami", "123", UserStatus.Active),
                new User("user-3", "Ignacio", "Esteves", "44180117", UserType.Voluntario, "nacho", "123", UserStatus.Active),
                new User("user-4", "Nicolás", "Salerno", "11223344", UserType.Transito, "niko", "123", UserStatus.Active),
                //more adoptants
                new User("user-5", "Martín", "González", "33445566", UserType.Adoptante, "martin", "123", UserStatus.Active),
                new User("user-6", "Laura", "Fernández", "44556677", UserType.Adoptante, "laura", "123", UserStatus.Active),
                new User("user-7", "Diego", "Rodríguez", "55667788", UserType.Adoptante, "diego", "123", UserStatus.Active),
                new User("user-8", "Sofía", "López", "66778899", UserType.Adoptante, "sofia", "123", UserStatus.Active)
                );
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

                //seeding data
                entity.HasData(
                    new Animal("1", "Firulais", Animal.SpeciesEn.Perro, new DateTime(2018, 5, 20), null, Animal.AnimalStateEn.Disponible, "Como es el bichito"),
                    new Animal("2", "Miau", Animal.SpeciesEn.Gato, new DateTime(2020, 3, 15), "user-5", Animal.AnimalStateEn.Adoptado, "Como es el bichito"),
                    new Animal("3", "Bunny", Animal.SpeciesEn.Conejo, new DateTime(2021, 7, 10), null, Animal.AnimalStateEn.Disponible, "Como es el bichito"),
                    new Animal("4", "Lola", Animal.SpeciesEn.Gato, new DateTime(2019, 2, 5), "user-4", Animal.AnimalStateEn.Adoptado, ""),
                    new Animal("5", "Rex", Animal.SpeciesEn.Perro, new DateTime(2017, 11, 30), "user-2", Animal.AnimalStateEn.Adoptado, "Como es el bichito"),
                    new Animal("6", "Coco", Animal.SpeciesEn.Conejo, new DateTime(2022, 1, 25), null, Animal.AnimalStateEn.Disponible, "Como es el bichito"),
                    new Animal("7", "Pepi", Animal.SpeciesEn.Pajaro, new DateTime(2016, 8, 18), "user-3", Animal.AnimalStateEn.Adoptado, "Como es el bichito"));
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
                    new House("house-1", "user-4", "Zeballos", 1341, 2)
                        );
            });
            //----- SIGHTING -----
            modelBuilder.Entity<Sighting>(entity =>
            { entity.HasKey(e => e.Id);
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
     }
 );
            });

            modelBuilder.Entity<MedicalCheckUp>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .IsRequired();

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId);

                entity.Property(e => e.AnimalId)
                    .IsRequired();

                entity.HasOne(e => e.Animal)
                    .WithMany()
                    .HasForeignKey(e => e.AnimalId);

                entity.Property(e => e.CheckUpDate)
                    .IsRequired();

                entity.Property(e => e.Observation)
                    .IsRequired();
                entity.HasData(
                new MedicalCheckUp(
                    "mc-1",
                    "user-3",
                    new DateTime(2024, 11, 15),
                    "Control de rutina. Vacunas al día. Estado general excelente.",
                    "7"
                ),
                new MedicalCheckUp(
                    "mc-2",
                    "user-3",
                    new DateTime(2024, 10, 20),
                    "Revisión post-adopción. El animal se ha adaptado bien. Se recomienda seguimiento en 3 meses.",
                    "5"
                ),
                new MedicalCheckUp(
                    "mc-3",
                    "user-3",
                    new DateTime(2024, 12, 5),
                    "Desparasitación realizada. Peso adecuado para su edad. Continuar con alimentación actual.",
                    "4"
                ),
                new MedicalCheckUp(
                    "mc-4",
                    "user-3",
                    new DateTime(2024, 9, 10),
                    "Control pre-adopción. Animal en condiciones óptimas para ser adoptado.",
                    "1"
                ),
                new MedicalCheckUp(
                    "mc-5",
                    "user-3",
                    new DateTime(2024, 8, 25),
                    "Revisión dental. Se detectó sarro leve. Se realizó limpieza. Buen estado general.",
                    "2"
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
                });
            });
        }
    }
}
