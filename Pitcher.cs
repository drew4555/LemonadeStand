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
        public Pitcher(Player player, Recipe recipe)
        {
            pitcher = recipe.lemon + recipe.ice + recipe.sugar;
            player.inventory.lemons -= recipe.lemon;
            player.inventory.ice -= recipe.ice;
            player.inventory.sugar -= recipe.sugar;
            cupsToPitcher = 10;
            InventoryCheck(player);
        }
        //member methods
        public void InventoryCheck(Player player, Game game)
        {
            if (player.inventory.lemons < player.recipe.lemon)
            {
                Console.WriteLine("you do not have enough lemons");
                game.endDay();
            }
            else if (player.inventory.ice < player.recipe.ice)
            {
                Console.WriteLine("You do not have enough Ice");
                game.endDay();
            }
            else if (player.inventory.sugar < player.recipe.sugar)
            {
                Console.WriteLine("you do not have enough Sugar");
                game.endDay();
            }
            else if (player.inventory.cups < player.pitcher.cupsToPitcher)
            {
                Console.WriteLine("you do not have enough cups");
                game.endDay();
            }
        }
        

           

    }
}
