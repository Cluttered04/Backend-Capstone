using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class FavoriteRaces
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int RaceId { get; set; }
        public Race Race { get; set; }
    }
}
