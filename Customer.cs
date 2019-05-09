using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        //has a
        public List<double> AmountOfPurchases;
        public List <Customer> AmountOfCustomers;
        public Weather weather;

        //constructor
        public Customer()
        {
            AmountOfCustomers = new List<Customer>();
            AmountOfPurchases = new List<double>();
        }
        //can do
        public void getRandomCustomers(Weather weather)
        {
           
            if (weather.currentCondition == "sunny")
            {
                Random CustomerNumber = new Random();
                int customerNumber = CustomerNumber.Next(40, 50);
                for (int i = 0; i < customerNumber; i++)
                {
                    AmountOfCustomers.Add (new Customer());
                }
            }
            else if (weather.currentCondition == "cloudy")
            {
                Random CustomerNumber1 = new Random();
                int customerNumber1 = CustomerNumber1.Next(35, 39);
                for (int i = 0; i < customerNumber1; i++)
                {
                    AmountOfCustomers.Add(new Customer());
                }
            }
            else if (weather.currentCondition == "muggy")
            {
                Random CustomerNumber = new Random();
                int customerNumber = CustomerNumber.Next(28, 34);
                for (int i = 0; i < customerNumber; i++)
                {
                    AmountOfCustomers.Add(new Customer());
                }
            }
            else if (weather.currentCondition == "raining")
            {
                Random CustomerNumber = new Random();
                int customerNumber = CustomerNumber.Next(17, 27);
                for (int i = 0; i < customerNumber; i++)
                {
                    AmountOfCustomers.Add(new Customer());
                }
            }
        }
        public void CustomersBuying(Weather weather)
        {
            if (weather.currentCondition == "sunny")
            {
                Random custbuy = new Random();
                int Customerbuy = custbuy.Next(30, AmountOfCustomers.Count);
                for (int i = 0; i < Customerbuy; i++)
                {
                    AmountOfPurchases.Add(1);
                }
            }
            else if (weather.currentCondition == "cloudy")
            {
                Random custbuy = new Random();
                int Customerbuy = custbuy.Next(23, AmountOfCustomers.Count);
                for (int i = 0; i < Customerbuy; i++)
                {
                    AmountOfPurchases.Add(1);
                }
            }
            else if (weather.currentCondition == "muggy")
            {
                Random custbuy = new Random();
                int Customerbuy = custbuy.Next(18, AmountOfCustomers.Count);
                for (int i = 0; i < Customerbuy; i++)
                {
                    AmountOfPurchases.Add(1);
                }
            }
            else if (weather.currentCondition == "raining")
            {
                Random custbuy = new Random();
                int Customerbuy = custbuy.Next(10, AmountOfCustomers.Count);
                for (int i = 0; i < Customerbuy; i++)
                {
                    AmountOfPurchases.Add(1);
                }
            }
        }
        public void DisplayCustomers()
        {
            Console.WriteLine("Number of customers Today " + AmountOfCustomers.Count);
            Console.WriteLine("Customers purchased " + AmountOfPurchases.Count + " " + "today");
            Console.ReadKey();
        }
    }
}
