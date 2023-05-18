using HashSet.Models;
using System;
using System.Collections.Generic;

namespace HashSet.Functionality
{
    public interface IWeatherOperations
    {
        int AddCountryWeather (CountryWeather countryWeather);
        HashSet<CountryWeather> GetCountries ();
        void UpdateCountry(string country);
        void SearchCountry(string country);
        void DeleteCountry(string country);
        void CountCountry();
    }
}
