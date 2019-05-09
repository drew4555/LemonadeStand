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

        //constructor
        public Recipe()
        {
            lemon = 4;
            sugar = 4;
            ice = 4;
            lemonadePrice = .25;
        }

        //member methods
        
        
        public void DisplayCurrentRecipe()
        {
            Console.WriteLine("The current lemonade recipe is\n " + lemon + " " + "Lemons, " + sugar + " " + "Sugar, and "
                + ice + " " + "Ice, ");
            Console.WriteLine("The current price of the lemonade is " + lemonadePrice);
        }

        

    }
}
