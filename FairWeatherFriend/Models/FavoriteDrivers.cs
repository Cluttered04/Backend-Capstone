using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class FavoriteDrivers
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string DriverId { get; set; }
    }
}
