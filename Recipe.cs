using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        public int lemon;
        public int sugar;
        public int ice;
        public int cup;
        public double lemonadePrice;
        public double lemonadeRecipe;

        //constructor
        public Recipe()
        {
            lemon = 4;
            sugar = 4;
            ice = 4;
            cup = 1;
            lemonadePrice = .25;
        }

        //member methods
        public void ChooseLemons()
        {
            Console.WriteLine("how many Lemons do you want to use?");
            lemon = int.Parse(Console.ReadLine());
        }
        public void ChooseSugar()
        {
            Console.WriteLine("how much sugar do you want to use?");
            sugar = int.Parse(Console.ReadLine());
        }
        public void ChooseIce()
        {
            Console.WriteLine("how much sugar do you want to use?");
            ice = int.Parse(Console.ReadLine());
        }
        public double PriceofLemonade()
        {
            Console.WriteLine("how much do you want to charge for your lemonade?");
            lemonadePrice = double.Parse(Console.ReadLine());
            return lemonadePrice;
        }
        public double MixLemonade()
        {
            lemonadeRecipe = sugar + ice + lemon + cup;
            return lemonadeRecipe;
        }

        

    }
}
