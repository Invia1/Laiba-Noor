using HashSet.BLL;
using HashSet.Functionality;
using HashSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HashSet.UI
{
     class WeatherMainApp
    {
        public static void Main()
        {
            string country;
            string confirm;
            CountryWeather countryWeather;
            IWeatherOperations weather = new WeatherMethods();

            do
            {
                Console.WriteLine("Press 1 to Add Country Weather in List");
                Console.WriteLine("Press 2 to Show Country Weather List");
                Console.WriteLine("Press 3 to Update Country Weather in List");
                Console.WriteLine("Press 4 to Delete Country Weather in List");
                Console.WriteLine("Press 5 to Search Country Weather in List");
                Console.WriteLine("Press 6 to Count Country Weather in List");
                Console.WriteLine("Press 7 to Exit the program");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        countryWeather = new CountryWeather();
                        Console.WriteLine("Enter the Country Name : ");
                        countryWeather.Country = Console.ReadLine();

                        Console.WriteLine("Enter the Maximum Temprature : ");
                        countryWeather.MaxTemperature = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Minimum Temprature : ");
                        countryWeather.MinTemperature = Convert.ToDouble(Console.ReadLine());

                        countryWeather.DateTime = DateTime.Now;

                        weather.AddCountryWeather(countryWeather);

                        break;
                    case 2:
                        Console.WriteLine("--------Country Weather List--------");
                        HashSet<CountryWeather> HC = weather.GetCountries();
                        foreach (var cw in HC)
                        {
                            Console.WriteLine("Country Name : " + cw.Country);
                            Console.WriteLine("Max Temprature : " + cw.MaxTemperature);
                            Console.WriteLine("Min Temprature : " + cw.MinTemperature);
                            Console.WriteLine("DateTime : " + cw.DateTime);

                            Console.WriteLine("");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Which country do you want to update? Please enter country name : ");
                        country = Console.ReadLine();
                        weather.UpdateCountry(country);
                        break;
                    case 4:
                        Console.WriteLine("Which country detail do you want to delete? Please enter country name : ");
                        country = Console.ReadLine();
                        weather.DeleteCountry(country);
                        break;
                    case 5:
                        Console.WriteLine("Which country do you want to search? Please enter country name : ");
                        country = Console.ReadLine();
                        weather.SearchCountry(country);
                        break;
                    case 6:
                        weather.CountCountry();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue the program? If Yes Press 'Y' else 'N'");
                confirm = Console.ReadLine();
            } while (confirm == "Y");

            Console.ReadLine();
        }
     }
}
