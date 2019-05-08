using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //has a 
        
        //constructor
        public Store()
        {

        }

        //can do
       public void DisplayPrices()
       {
            Console.WriteLine("Prices are as follows: Lemons:\n 5 for 1.00\n 10 for 2.00\n 20 for 3.00\n" +
                "Sugar:\n 5 for 1.00\n 10 for 2.00\n 20 for 3.00\n Ice:\n 5 for 1.00\n 10 for 2.00\n 20 for 3.00\n" +
                "Cups:\n 25 for 1.00\n 50 for 2.00\n 100 for 3.00\n");
            Console.ReadKey();
       }
       public void Shopping(Player player)
       {
            Console.WriteLine("What would you like to purchase?");
            string buying = Console.ReadLine().ToLower();
            switch (buying)
            {
                case "lemons":
                    BuyLemons(player);
                    ContinueShopping(player);
                    break;

                case "sugar":
                    BuySugar(player);
                    ContinueShopping(player);
                    break;

                case "ice":
                    BuyIce(player);
                    ContinueShopping(player);
                    break;

                case "cups":
                    BuyCups(player);
                    ContinueShopping(player);
                    break;

                default:
                    Console.WriteLine("You must choose either Lemons, Sugar, Ice, or Cups");
                    break;
            }
       }
        public void ContinueShopping(Player player)
        {
            Console.WriteLine("Would you like to continue shopping?");
            string continueShopping = Console.ReadLine().ToLower();
            switch (continueShopping)
            {
                case "yes":
                    Shopping(player);
                    break;

                case "no":
                    break;
            }
        }

        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy? ((5, 10, or 20,)");
            string quantity = Console.ReadLine();
            switch (quantity)
            {
                case "5":
                    player.inventory.lemons += 5;
                    player.playerwallet -= 1.00;
                    break;

                case "10":
                    player.inventory.lemons += 10;
                    player.playerwallet -= 2.00;
                    break;

                case "20":
                    player.inventory.lemons += 20;
                    player.playerwallet -= 3.00;
                    break;

                default:
                    Console.WriteLine("Please choose either 5, 10, or 20");
                    break;
            }
        }

        public void BuySugar(Player player)
        {
            Console.WriteLine("How many (5, 10, or 20,");
            string quantity1 = Console.ReadLine();
            switch (quantity1)
            {
                case "5":
                    player.inventory.sugar += 5;
                    player.playerwallet -= 1.00;
                    break;

                case "10":
                    player.inventory.sugar += 10;
                    player.playerwallet -= 2.00;
                    break;

                case "20":
                    player.inventory.sugar += 20;
                    player.playerwallet -= 3.00;
                    break;

                default:
                    Console.WriteLine("Please choose either 5, 10, or 20");
                    break;
            }
        }
        public void BuyIce(Player player)
        {
            Console.WriteLine("How many (5, 10, or 20,");
            string quantity2 = Console.ReadLine();
            switch (quantity2)
            {
                case "5":
                    player.inventory.ice += 5;
                    player.playerwallet -= 1.00;
                    break;

                case "10":
                    player.inventory.ice += 10;
                    player.playerwallet -= 2.00;
                    break;

                case "20":
                    player.inventory.ice += 20;
                    player.playerwallet -= 3.00;
                    break;

                default:
                    Console.WriteLine("Please choose either 5, 10, or 20");
                    break;
            }
        }
        public void BuyCups(Player player)
        {
            Console.WriteLine("How many (25, 50, or 100,");
            string quantity3 = Console.ReadLine();
            switch (quantity3)
            {
                case "25":
                    player.inventory.cups += 25;
                    player.inventory.playercash -= 1.00;
                    break;

                case "50":
                    player.inventory.cups += 50;
                    player.inventory.playercash -= 2.00;
                    break;

                case "100":
                    player.inventory.cups += 100;
                    player.inventory.playercash -= 3.00;
                    break;

                default:
                    Console.WriteLine("Please choose either 25, 50, or 100");
                    break;
            }
        }
    }
}
