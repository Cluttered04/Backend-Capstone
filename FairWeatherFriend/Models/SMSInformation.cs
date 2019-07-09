using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWeatherFriend.Models
{
    public class SMSInformation
    {
        public SMSInformation()
        {
            token = "3ac3fde5825ee97bae8f1cc956c2398c";
            sid = "ACd2dd5a95fedd7d5712978e9119ddf015";
            phone = "15106216658";
        }
        
        public string token;

        public string sid;
        public string phone;
        public string userPhone { get; set; }
    }
}
