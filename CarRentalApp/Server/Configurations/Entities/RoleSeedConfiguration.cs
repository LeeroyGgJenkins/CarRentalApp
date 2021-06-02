using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "654176FF-0BEB-431A-9A0A-2D0E4378EE9A",
                    Name="User",
                    NormalizedName="USER"
                },
                new IdentityRole
                {
                    Id = "A93DFAED-4AB6-4379-9239-7E9DD503A4F9",
                    Name="Admin",
                    NormalizedName="ADMIN"
                }
                );
        }
    }
}
