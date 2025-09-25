using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;


namespace Infrastructure.Data
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<House> Houses { get; set; }

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
                new User("user-4", "Nicolás", "Salerno", "11223344", UserType.Transito, "niko", "123", UserStatus.Active));
               
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
                    new Animal("2", "Miau", Animal.SpeciesEn.Gato, new DateTime(2020, 3, 15), null, Animal.AnimalStateEn.Disponible, "Como es el bichito"),
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
        }
    }
}
