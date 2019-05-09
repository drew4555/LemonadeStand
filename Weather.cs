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
        public int actualTemp;
        public List<string> weatherConditions;
        public string currentCondition;
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
        }
        //can do //member methods
        public void GetForcastedTemp()
        {
            Random ForcastedTemps = new Random();
            while (forcastedTemps.Count < 7)
            {
                forcastedTemps.Add(ForcastedTemps.Next(60, 100));
            }
        }
        public int GetActualTemp()
        {
            Random ActualTemp = new Random();
            actualTemp = ActualTemp.Next(60, 100);
            return actualTemp;
        }
        public string GetWeatherCondition()
        {
            Random WeatherCondition = new Random();
            index = WeatherCondition.Next(weatherConditions.Count);
            if (weatherConditions[index] == "sunny")
            {
                currentCondition = "sunny";
            }
            else if (weatherConditions[index] == "muggy")
            {
                currentCondition = "muggy";
            }
            else if (weatherConditions[index] == "raining")
            {
                currentCondition = "raining";
            }
            else if (weatherConditions[index] == "cloudy") 
            {
                currentCondition = "cloudy";
            }
            return currentCondition;
        }
        public void DisplayWeather()
        {
            Console.WriteLine("actual temp: " + actualTemp);
            Console.WriteLine("It is currently " + currentCondition);
            //Console.ReadKey();
        }
    }
}
