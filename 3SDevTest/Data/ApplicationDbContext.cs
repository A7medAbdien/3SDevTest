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
        public DbSet<User> Categories { get; set; }

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
                    BirthDate = new DateOnly(2023, 10, 12),
                    AddressList = new Address
                    {
                        BuildingNumber = 1,
                        FlatNumber = 1,
                        Street = "1111"
                    }
                }, 
                new User
                {
                    Id = 2,
                    FirstName = "FirstName2",
                    MiddleName = "MiddleName2",
                    LastName = "LastName2",
                    Email = "ex@gmail.com",
                    MobileNumber = "+022006258223",
                    BirthDate = new DateOnly(2023, 20, 22),
                    AddressList = new Address
                    {
                        BuildingNumber = 2,
                        FlatNumber = 2,
                        Street = "2222"
                    }
                },
                new User
                {
                    Id = 3,
                    FirstName = "FirstName3",
                    MiddleName = "MiddleName3",
                    LastName = "LastName3",
                    Email = "ex@gmail.com",
                    MobileNumber = "+023006358323",
                    BirthDate = new DateOnly(2023, 30, 32),
                    AddressList = new Address
                    {
                        BuildingNumber = 3,
                        FlatNumber = 3,
                        Street = "3333"
                    }
                }
                );
        }

    }
}
