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
        public bool isBuying;

        //constructor
        public Customer(Weather weather, Random isBuy)
        {
 
            this.weather = weather;
            ChooseToBuy(isBuy);
        }

        //member methods
        public void ChooseToBuy(Random isBuy)
        {
            int isbuying = isBuy.Next(0, 101);
            if (isbuying % 2 == 0 && weather.currentCondition == "sunny")
            {
                isBuying = true;
            }
            else if(isbuying % 3 == 0 && weather.currentCondition == "cloudy")
            {
                isBuying = true;
            }
            else if (isbuying % 5 == 0 && weather.currentCondition == "muggy")
            {
                isBuying = true;
            }
            else if (isbuying % 7 == 0 && weather.currentCondition == "raining")
            {
                isBuying = true;
            }
            else
            {
                isBuying = false;
            }
        }
    }
}
