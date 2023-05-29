using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Organization.Entities;

namespace Organization.Repository.Services
{
    public class CompanyOptions : IEntityTypeConfiguration<Company>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = 1,
                    Name = "Company1"
                },
                new Company
                {
                    Id = 2,
                    Name = "Company2"
                },
                new Company
                {
                    Id = 3,
                    Name = "Company3"
                }
            );
        }
    }
}