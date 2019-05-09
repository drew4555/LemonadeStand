using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer : CustomerBase
    {
        //member varaibles

        //constructor
        public Customer()
        {
            ChooseToBuy(weather);
        }

        //member methods
        public bool ChooseToBuy(Weather weather)
        {
            Random isbuy = new Random();
            int Isbuying = isbuy.Next(0, 100);
            if (Isbuying % 2 == 0 && weather.currentCondition == "sunny")
            {
                return true;
            }
            else if(Isbuying % 3 == 0 && weather.currentCondition == "cloudy")
            {
                return true;
            }
            else if (Isbuying % 5 == 0 && weather.currentCondition == "muggy")
            {
                return true;
            }
            else if (Isbuying % 7 == 0 && weather.currentCondition == "raining")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
