using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class MakeSeedConfig : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Toyota",
                    UpdatedBy = "System"
                },
                 new Make
                 {
                     Id = 2,
                     CreatedBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     Name = "BMW",
                     UpdatedBy = "System"
                 },
                 new Make
                 {
                     Id = 3,
                     CreatedBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     Name = "Subaru",
                     UpdatedBy = "System"
                 }
                );
        }
    }
}
