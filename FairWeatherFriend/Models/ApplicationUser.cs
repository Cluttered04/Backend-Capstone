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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public List<ParticipatingDriver> ParticipatingDrivers { get; set; } = new List<ParticipatingDriver>();


        // Set up PK -> FK relationships to other objects

    }
}
