﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jobSalt.Models.Data_Types
{
    public enum States { AL, AK, AS, AZ, AR, CA, CO, CT, DE, DC, FM, 
                         FL, GA, GU, HI, ID, IL, IN, IA, KS, KY, LA,
                         ME, MH, MD, MA, MI, MN, MS, MO, MT, NE, NV,
                         NH, NJ, NM, NY, NC, ND, MP, OH, OK, OR, PW,
                         PA, PR, RI, SC, SD, TN, TX, UT, VT, VI, VA,
                         WA, WV, WI, WY } 

    public class Location
    {
        public Location(string zip = "n/a", string state = "n/a", string city = "n/a")
        {
            this.ZipCode = zip;
            this.State = state;
            this.City = city;
        }

        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public class LocationResult { public Location location { get; set; }   }
    }
}