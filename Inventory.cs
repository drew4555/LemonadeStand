﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //has a
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public double playercash;

        //constructor
        public Inventory()
        {
            lemons = 0;
            sugar = 0;
            ice = 0;
            cups = 0;
            playercash = 25;
        }

        //can do

        public void DisplayCurrentInventory()
        {
            Console.WriteLine("CurrentInventory");
            Console.WriteLine("Lemons: " + lemons);
            Console.WriteLine("Sugar: " + sugar);
            Console.WriteLine("Ice: " + ice);
            Console.WriteLine("Cups: " + cups);
            Console.WriteLine("Remaing Money: $" + playercash);
        }

    }
}
