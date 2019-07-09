using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        [Display(Name = "Car Number")]
        public string CarNumber { get; set; }

        public bool isAdmin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Set up PK -> FK relationships to other objects

    }
}
