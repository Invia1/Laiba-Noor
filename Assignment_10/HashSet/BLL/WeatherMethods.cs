using HashSet.Functionality;
using HashSet.Models;
using System;
using System.Collections.Generic;


namespace HashSet.BLL
{
    public class WeatherMethods :IWeatherOperations
    {
        HashSet<CountryWeather> HWeather = new HashSet<CountryWeather>();
        public int AddCountryWeather(CountryWeather countryWeather)
        {
            HWeather.Add(countryWeather);
            return 1;
        }
        public HashSet<CountryWeather> GetCountries()
        {
            return HWeather;
        }

        public void UpdateCountry(string country)
        {
            HashSet<CountryWeather> countries = GetCountries();
            try
            {
                foreach(CountryWeather countryW in countries)
                {
                    if(countryW.Country == country)
                    {
                        Console.WriteLine("Enter the updated country name : ");
                        countryW.Country = Console.ReadLine();

                        Console.WriteLine("Enter the updated max temprature : ");
                        countryW.MaxTemperature = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the updated min temprature : ");
                        countryW.MinTemperature = Convert.ToDouble(Console.ReadLine());

                        countryW.DateTime = DateTime.Now;
                        Console.WriteLine("");
                        Console.WriteLine("Data has been updated successfully!!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Country Name !! Please Try Again");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       public void SearchCountry(string country)
        {
            HashSet<CountryWeather> countries = GetCountries();
            try
            {
                foreach (CountryWeather countryW in countries)
                {
                    if (countryW.Country == country)
                    {
                        Console.WriteLine("Country Name : " + countryW.Country);
                        Console.WriteLine("Max Temprature : " + countryW.MaxTemperature);
                        Console.WriteLine("Min Temprature : " + countryW.MinTemperature);
                        Console.WriteLine("DateTime : " + countryW.DateTime);

                    }
                    else
                    {
                        Console.WriteLine("Country Not Found !!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteCountry(string country)
        {
            HashSet<CountryWeather> countries = GetCountries();
            try
            {
                foreach (CountryWeather countryW in countries)
                { 
                    if (countryW.Country == country) 
                    {
                        countries.Remove(countryW);
                        Console.WriteLine("Data has been deleted successfully!!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Country Name !! Please Try Again");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CountCountry()
        {
            HashSet<CountryWeather> countries = GetCountries();
            int count = countries.Count;
            Console.WriteLine("Count of available countries are : {0}", count.ToString());
        }
    }
}
