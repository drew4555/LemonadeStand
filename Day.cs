using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    { 
        //has a
        public Weather weather;
        public List<Customer> AmountOfCustomers;
        public CustomerBase customer;
        //constructor
        public Day()
        {
            weather = new Weather();
            customer = new CustomerBase(weather);


        }

        //can do
        //public void SellLemonade(Player player, Customer customer)
        //{
        //    foreach(Customer buys in AmountOfCustomers)
        //    {
        //        if (poop)
        //        {
        //            thing.inventory.cups--;
        //        }
        //    }
        //}
    }
}
