using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Organization.Entities;

namespace Organization.Repository.Services
{
    public class EmployeeOptions : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Email = "mail@mail.ru",
                    Position = "Manager",
                    Salary = 100000
                },
                new Employee
                {
                    Id = 2,
                    Email = "mail1@mail.ru",
                    Position = "Manager",
                    Salary = 200000
                },
                new Employee
                {
                    Id = 3,
                    Email = "mail2@mail.ru",
                    Position = "Programmer",
                    Salary = 100000
                }

            );
        }
    }
}