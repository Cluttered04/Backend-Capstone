using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class Race
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Date")]
        public DateTime TimeOfDay { get; set; }
        [Display(Name = "Cancelled")]
        public bool isCancelled { get; set; }
        public int Prize { get; set; }
        public string Name { get; set; }
        public int Laps { get; set; }
        [Required]
        public int RaceTrackId { get; set; }
        public RaceTrack Track { get; set; }
    }
}
