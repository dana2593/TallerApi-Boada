﻿using System.Collections;

namespace TallerApi_Boada.Models
{
    public class Country
    {
        public CountryName name { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public ArrayList capital { get; set; }
    }
}
