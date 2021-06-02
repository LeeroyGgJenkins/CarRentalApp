using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        //This is where I customize the information that must be provided by users
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
