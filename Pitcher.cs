using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        //member variables
        public double pitcher;
        public double cupsToPitcher;

        //constructor
        public Pitcher(Player player, Recipe recipe, List<Day> daysPlayed, List<double> noOfCustomersBought)
        {
            pitcher = recipe.lemon + recipe.ice + recipe.sugar;
            
            cupsToPitcher = 10;
            InventoryCheck(player, daysPlayed, noOfCustomersBought );
        }
        //member methods
        public void InventoryCheck(Player player, List<Day> daysPlayed, List<double> noOfCustomersBought)
        {
            if (player.inventory.lemons < player.recipe.lemon)
            {
                Console.WriteLine("you do not have enough lemons");
                daysPlayed[1].EndDay(noOfCustomersBought);
            }
            else if (player.inventory.ice < player.recipe.ice)
            {
                Console.WriteLine("You do not have enough Ice");
                daysPlayed[1].EndDay(noOfCustomersBought);
            }
            else if (player.inventory.sugar < player.recipe.sugar)
            {
                Console.WriteLine("you do not have enough Sugar");
                daysPlayed[1].EndDay(noOfCustomersBought);
            }
            else if (player.inventory.cups < cupsToPitcher)
            {
                Console.WriteLine("you do not have enough cups");
                daysPlayed[1].EndDay(noOfCustomersBought);
            }
            else if (player.inventory.lemons > player.recipe.lemon && player.inventory.ice > player.recipe.ice && player.inventory.sugar >
                player.recipe.sugar)
            {
                player.inventory.lemons -= player.recipe.lemon;
                player.inventory.ice -= player.recipe.ice;
                player.inventory.sugar -= player.recipe.sugar;
            }
        }
    }
}
