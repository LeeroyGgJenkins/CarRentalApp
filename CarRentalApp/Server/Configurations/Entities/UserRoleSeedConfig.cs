using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class UserRoleSeedConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "654176FF-0BEB-431A-9A0A-2D0E4378EE9A",
                    UserId= "78DCC559-D2D4-4741-82AB-501F81370AA5"
                }, 
                new IdentityUserRole<string>
                {
                    RoleId = "A93DFAED-4AB6-4379-9239-7E9DD503A4F9",
                    UserId = "2D7A5855-7973-4829-BC0D-80D1099F72D9"
                }
                );
        }
    }
}
