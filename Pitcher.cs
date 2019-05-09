using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables
        public Player player;
        public Recipe recipe;
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
            
        }
        //member methods

    }
}
