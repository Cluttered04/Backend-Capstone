using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class RaceTrack
    {
        public int Id { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ZipCode { get; set; }
        public List<Race> Races { get; set; } = new List<Race>();
    }
}
