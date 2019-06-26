using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class Race
    {
        [Required]
        public DateTime TimeOfDay { get; set; }
        public bool isCancelled { get; set; }
        public int Prize { get; set; }
        [Required]
        public int RaceTrackId { get; set; }
        public RaceTrack Track { get; set; }
    }
}
