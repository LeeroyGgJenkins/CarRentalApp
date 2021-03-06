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
                    //Make a Unique Role ex"AdminIGA" for each company that has some admin rights save his GUID 
                    //makes a unique User ex"adminIga_Sebastien" 
                    //make a User Role for adminIga_Sebastien that pairs his GUID with the IGA admin GUID
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
