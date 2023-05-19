using System;


namespace HashSet.Models
{
    public class CountryWeather
    {
        public string Country { get; set; }
        public double MaxTemperature { get; set; }

        public double MinTemperature { get; set; }
        public DateTime DateTime { get; set; }
        
        public override bool Equals(object obj)
        {
            CountryWeather CW = obj as CountryWeather;
            return CW != null && CW.Country == Country && CW.MaxTemperature == MaxTemperature && CW.MinTemperature == MinTemperature;
        }
        public override int GetHashCode()
        {
            return Country.GetHashCode() ^ MaxTemperature.GetHashCode() ^ MinTemperature.GetHashCode();
        }
    }
}
