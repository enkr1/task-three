using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//Learned from https://www.youtube.com/watch?v=tdNoArSjIyY
namespace Task3.Models
{
    public class ReCAPTCHASettings
    {
        public string reCAPTCHA_Site_Key { get; set; }

        public string reCAPTCHA_Secret_Key { get; set; }
    }
}