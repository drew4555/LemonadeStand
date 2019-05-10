using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //has a 
        public Inventory inventory;
        public Pitcher pitcher;
        public Recipe recipe;

        //spawner
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
        }

        //can do
        public void ChooseLemons()
        {
            Console.WriteLine("how many Lemons do you want to use?");
            recipe.lemon = int.Parse(Console.ReadLine());
        }
        public void ChooseSugar()
        {
            Console.WriteLine("how much sugar do you want to use?");
            recipe.sugar = int.Parse(Console.ReadLine());
        }
        public void ChooseIce()
        {
            Console.WriteLine("how much sugar do you want to use?");
            recipe.ice = int.Parse(Console.ReadLine());
        }
        public void PriceofLemonade()
        {
            Console.WriteLine("how much do you want to charge for your lemonade?");
            recipe.lemonadePrice = double.Parse(Console.ReadLine());
        }
        public void SellLemonade(Player player, Pitcher pitcher)
        {
            while (pitcher.cupsToPitcher > 0 && player.inventory.lemons > recipe.lemon && player.inventory.sugar > recipe.sugar && 
                player.inventory.ice > recipe.ice)
            {
                pitcher.cupsToPitcher--;
                if(pitcher.cupsToPitcher == 0)
                {
                    pitcher = new Pitcher(player,recipe);
                }
            }
        }
    }
}
