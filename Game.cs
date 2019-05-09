using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //has a 
        public List<Day> daysPlayed;
        public Store store;
        public Player player;
        public Weather weather;
        public Day day;
        public Inventory inventory;
        public Recipe recipe;
        public CustomerBase customer;





        //spawner
        public Game()
        {
            RunGame();
        }
        //can do
        public void RunGame()
        {
            Start();
            GetDays();

            while (daysPlayed.Count > 0)
            {
                new Weather();
                inventory.DisplayCurrentInventory();
                Console.WriteLine("Do you want to go to store?");
                string shop = Console.ReadLine().ToLower();
                switch (shop)
                {
                    case "yes":
                        {
                            Console.Clear();
                            store.DisplayPrices();
                            store.Shopping(player);
                            break;
                        }
                    case "no":
                        {
                            break;
                        }
                }
                Console.Clear();
                weather.DisplayWeather();
                player.inventory.DisplayCurrentInventory();
                Console.ReadKey();
                recipe.DisplayCurrentRecipe();
                Console.WriteLine("Would you like to change the current recipe");
                string recipechange = Console.ReadLine().ToLower();
                switch (recipechange)
                {
                    case "yes":
                        player.ChooseLemons();
                        player.ChooseSugar();
                        player.ChooseIce();
                        player.PriceofLemonade();
                        break;

                    case "no":
                        //day.RunDay();
                        break;
                }
                customer.getRandomCustomers(weather);
                customer.DisplayCustomers();

            }


                //for(int i= 0; i < daysPlayed.Count; i++)
                //{
                //    // run a whole day!
                //    // display weather 
                //    // display forcast
                //    // ask to go to store
                //    // run stand
                //    // get end of day report
                //    daysPlayed[i].weather.DisplayWeather();




            

            void Start()
            {
                Console.WriteLine("Welcome to LemonadeStand");
                Console.ReadKey();
                Console.Clear();
            }

            void GetDays()
            {
                Console.WriteLine("Please Choose the Number of Days You would Like To Play (7, 14, or 30)");
                string noOfDays;
                noOfDays = Console.ReadLine();

                switch (noOfDays)
                {
                    case "7":
                        while (daysPlayed.Count < 7)
                        {
                            Day day1 = new Day();
                            daysPlayed.Add(day1);
                        }
                        break;
                    case "14":
                        while (daysPlayed.Count < 14)
                        {
                            Day day1 = new Day();
                            daysPlayed.Add(day1);
                        }
                        break;
                    case "30":
                        while (daysPlayed.Count < 30)
                        {
                            Day day1 = new Day();
                            daysPlayed.Add(day1);
                        }
                        break;
                    default:
                        Console.WriteLine("You Must Choose Either 7,14, or 30");
                        Console.ReadKey();
                        Console.Clear();
                        GetDays();
                        break;
                }
                Console.WriteLine("You are playing for " + daysPlayed.Count + " days");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}



