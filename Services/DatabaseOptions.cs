using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities = Organization.Entities;

namespace Organization.Services
{
    public class DatabaseOptions
    {
        public static void SeedAdressData(EntityTypeBuilder<Entities.Adress> builder)
        {
            builder.HasData(
                new Entities.Adress
                {
                    Country = "Russia",
                    City = "Moscow"
                },
                new Entities.Adress
                {
                    Country = "China",
                    City = "Beihing"
                }
            );
        }
        public static void SeedEmployeeData(EntityTypeBuilder<Entities.Employee> builder)
        {
            builder.HasData(
                new Entities.Employee
                {
                    Id = 1,
                    Email = "mail@mail.ru",
                    Position = "Manager",
                    Salary = 100000
                },
                new Entities.Employee
                {
                    Id = 2,
                    Email = "mail1@mail.ru",
                    Position = "Manager",
                    Salary = 200000
                },
                new Entities.Employee
                {
                    Id = 3,
                    Email = "mail2@mail.ru",
                    Position = "Programmer",
                    Salary = 100000
                }

            );
        }
        public static void SeedOrganizationData(EntityTypeBuilder<Entities.Organization> builder)
        {
            builder.HasData(
                new Entities.Organization
                {
                    Id = 1,
                    Name = "Company1"
                },
                new Entities.Organization
                {
                    Id = 2,
                    Name = "Company2"
                },
                new Entities.Organization
                {
                    Id = 3,
                    Name = "Company3"
                }
            );
        }
    }
}