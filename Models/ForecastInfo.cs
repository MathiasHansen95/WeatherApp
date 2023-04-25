﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    internal class ForecastInfo
    {
        public class Main
        {
            public double temp { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }

        }
       
        public class Weather
        {
            public string main { get; set; }    
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class List
        {
            public long dt { get; set; }
            public Main main { get; set; }
            public List<Weather> weather { get; set; }

        }

        public class ForecastInf
        {
            public List<List> list { get; set; }
        }


    }
}
