using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //has a //member variables
        private List<int> forcastedTemps;
        private int forecastedTemperature;
        public int actualTemp;
        public List<string> weatherConditions;
        private int index;
        //constructor
        public Weather()
        {
            weatherConditions = new List<string>();
            forcastedTemps = new List<int>();
            weatherConditions.Add("sunny");
            weatherConditions.Add("cloudy");
            weatherConditions.Add("raining");
            weatherConditions.Add("muggy");
            GetForcastedTemp();
            GetActualTemp();
            GetWeatherCondition();
            // DisplayWeather();
        }
        //can do //member methods
        private void GetForcastedTemp()
        {
            Random ForcastedTemp = new Random();
            while (forcastedTemps.Count < 7)
            {
                forcastedTemps.Add(ForcastedTemp.Next(60, 100));
            }
        }
        private int GetActualTemp()
        {
            Random ActualTemp = new Random();
            actualTemp = ActualTemp.Next(60, 100);
            return actualTemp;
        }
        private string GetWeatherCondition()
        {
            Random WeatherCondition = new Random();
            index = WeatherCondition.Next(weatherConditions.Count);
            return weatherConditions[index];
        }
        public void DisplayWeather()
        {
        //    Console.WriteLine("7 day forcast:");
        //    forcastedTemps.ForEach(i => Console.Write("{0}\t", i))  ;
            Console.WriteLine("\nactual temp: " + actualTemp);
            Console.WriteLine("It is currently " + weatherConditions[index]);
            Console.ReadKey();
        }
    }
}
