﻿using System;
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
        public CustomerBase customer;

 
        //constructor
        public Day(Random rng)
        {
            weather = new Weather(rng);
            customer = new CustomerBase(weather, rng);
        }

        //can do
        public void SellLemonade(Player player, Pitcher pitcher)

        {
            foreach (Customer potintialPurchaser in customer.AmountOfCustomers)
            {
                if (potintialPurchaser.isBuying == true)
                {
                    player.inventory.cups--;
                    player.inventory.playercash += player.recipe.lemonadePrice;
                    pitcher.cupsToPitcher--;
                    Console.WriteLine("You sold alot today");
                }
            }
        }
    }
}
