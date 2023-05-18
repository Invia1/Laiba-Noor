using System;


namespace HashSet.Models
{
    public class CountryWeather
    {
        public string Country { get; set; }
        public double MaxTemperature { get; set; }

        public double MinTemperature { get; set; }
        public DateTime DateTime { get; set; }
    }
}
