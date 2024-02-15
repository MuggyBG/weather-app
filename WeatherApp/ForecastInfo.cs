using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class ForecastInfo
    {

        public class Rootobject
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
            public float generationtime_ms { get; set; }
            public int utc_offset_seconds { get; set; }
            public string timezone { get; set; }
            public string timezone_abbreviation { get; set; }
            public float elevation { get; set; }
            public Hourly_Units hourly_units { get; set; }
            public Hourly hourly { get; set; }
            public Daily_Units daily_units { get; set; }
            public Daily daily { get; set; }
        }

        public class Hourly_Units
        {
            public string time { get; set; }
            public string temperature_2m { get; set; }
            public string precipitation_probability { get; set; }
            public string precipitation { get; set; }
            public string weather_code { get; set; }
        }

        public class Hourly
        {
            public int[] time { get; set; }
            public float[] temperature_2m { get; set; }
            public int[] precipitation_probability { get; set; }
            public float[] precipitation { get; set; }
            public int[] weather_code { get; set; }
        }

        public class Daily_Units
        {
            public string time { get; set; }
            public string temperature_2m_max { get; set; }
            public string temperature_2m_min { get; set; }
            public string precipitation_sum { get; set; }
            public string precipitation_hours { get; set; }
            public string precipitation_probability_max { get; set; }
        }

        public class Daily
        {
            public int[] time { get; set; }
            public float[] temperature_2m_max { get; set; }
            public float[] temperature_2m_min { get; set; }
            public float[] precipitation_sum { get; set; }
            public float[] precipitation_hours { get; set; }
            public int[] precipitation_probability_max { get; set; }
        }


    }

}
