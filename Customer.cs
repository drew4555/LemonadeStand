using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        //member varaibles
        public Weather weather;

        //constructor
        public Customer(Weather weather, Random isBuy)
        {
 
            this.weather = weather;
            ChooseToBuy(isBuy);
        }

        //member methods
        public bool ChooseToBuy(Random isBuy)
        {
            int Isbuying = isBuy.Next(0, 101);
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
