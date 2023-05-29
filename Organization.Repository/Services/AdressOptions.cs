using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organization.Entities;

namespace Organization.Repository.Services
{
    public class AdressOptions : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasData(
                new Adress
                {
                    Country = "Russia",
                    City = "Moscow"
                },
                new Adress
                {
                    Country = "China",
                    City = "Beihing"
                }
            );
        }
    }
}