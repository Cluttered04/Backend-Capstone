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
        public string DateOnly { get
            {
                return TimeOfDay.ToShortDateString().ToString();
            } set { } }
        [Display(Name = "Status")]
        public bool isCancelled { get; set; }
        public int Prize { get; set; }
        [Display(Name = "Race Name")]
        public string Name { get; set; }
        public int Laps { get; set; }
        [Required]
        public int RaceTrackId { get; set; }
        public RaceTrack Track { get; set; }
        public List<FavoriteRaces> FavoriteRaces { get; set; } = new List<FavoriteRaces>();
        public List<ParticipatingDriver> ParticipatingDrivers { get; set; } = new List<ParticipatingDriver>();
    }
}
