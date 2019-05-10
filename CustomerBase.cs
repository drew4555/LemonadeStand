using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CustomerBase
    {
        //has a
        public List <Customer> AmountOfCustomers;
        public Weather weather;
        public List<string> weatherConditions;

        //constructor
        public CustomerBase(Weather weather, Random isBuy)
        {
            this.weather = weather;
            AmountOfCustomers = new List<Customer>();
            getRandomCustomers(weather, isBuy);
        }
        //can do
        public void getRandomCustomers(Weather weather, Random isBuy)
        {
            if (weather.currentCondition == "sunny")
            {
                Random CustomerNumber = new Random();
                int customerNumber = CustomerNumber.Next(40, 50);
                for (int i = 0; i < customerNumber; i++)
                {
                    AmountOfCustomers.Add (new Customer(weather, isBuy));
                }
            }
            else if (weather.currentCondition == "cloudy")
            {
                Random CustomerNumber1 = new Random();
                int customerNumber1 = CustomerNumber1.Next(35, 39);
                for (int i = 0; i < customerNumber1; i++)
                {
                    AmountOfCustomers.Add(new Customer(weather, isBuy));
                }
            }
            else if (weather.currentCondition == "muggy")
            {
                Random CustomerNumber = new Random();
                int customerNumber = CustomerNumber.Next(28, 34);
                for (int i = 0; i < customerNumber; i++)
                {
                    AmountOfCustomers.Add(new Customer(weather, isBuy));
                }
            }
            else if (weather.currentCondition == "raining")
            {
                Random CustomerNumber = new Random();
                int customerNumber = CustomerNumber.Next(17, 27);
                for (int i = 0; i < customerNumber; i++)
                {
                    AmountOfCustomers.Add(new Customer(weather, isBuy));
                }
            }
        }
    }
}
