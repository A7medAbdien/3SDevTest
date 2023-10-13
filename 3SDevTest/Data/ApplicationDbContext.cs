using _3SDevTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace _3SDevTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Governate> Governates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "FirstName1",
                    MiddleName = "MiddleName1",
                    LastName = "LastName1",
                    Email = "ex@gmail.com",
                    MobileNumber = "+021006158123",
                    BirthDate = new DateTime(2020, 10, 1)
                },
                new User
                {
                    Id = 2,
                    FirstName = "FirstName2",
                    MiddleName = "MiddleName2",
                    LastName = "LastName2",
                    Email = "ex@gmail.com",
                    MobileNumber = "+022006258223",
                    BirthDate = new DateTime(2020, 10, 2)
                },
                new User
                {
                    Id = 3,
                    FirstName = "FirstName3",
                    MiddleName = "MiddleName3",
                    LastName = "LastName3",
                    Email = "ex@gmail.com",
                    MobileNumber = "+023006358323",
                    BirthDate = new DateTime(2020, 10, 3)
                }
                );

            modelBuilder.Entity<Governate>().HasData(
                new Governate
                {
                    Id = 1,
                    Name = "Governate 1"
                },
                new Governate
                {
                    Id = 2,
                    Name = "Governate 2"
                }
                );

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    GovernateId = 1,
                    Name = "City1Gove1"
                },
                new City
                {
                    Id = 2,
                    GovernateId = 1,
                    Name = "City2Gove1"
                },
                new City
                {
                    Id = 3,
                    GovernateId = 2,
                    Name = "City3Gove2"
                }
                );

            modelBuilder.Entity<Address>().HasData(
                new Address{
                    Id = 1,
                    UserId = 1,
                    Governate= "Governate 1",
                    CityId = 1,
                    FlatNumber = 1,
                    BuildingNumber = 1,
                    Street = "1"
                },
                new Address{
                    Id = 2,
                    UserId = 2,
                    Governate= "Governate 1",
                    CityId = 2,
                    FlatNumber = 2,
                    BuildingNumber = 2,
                    Street = "2"
                },
                new Address{
                    Id = 3,
                    UserId = 3,
                    Governate= "Governate 2",
                    CityId = 3,
                    FlatNumber = 3,
                    BuildingNumber = 3,
                    Street = "3"
                }
                );
        }

    }
}
