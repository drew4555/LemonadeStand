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
        public CustomerBase customerbase;
        public Customer customer;
        public List<Customer> AmountOfCustomers;
        public int i;

        //spawner
        public Game()
        {
            i = 1;
            daysPlayed = new List<Day>();
            player = new Player();
            store = new Store();
            inventory = new Inventory();
            recipe = new Recipe();
            AmountOfCustomers = new List<Customer>();
            RunGame(daysPlayed, player);

        }
        //can do
        public void RunGame(List<Day> daysPlayed, Player player)
        {
            Start();
            GetDays();
            while (i <= daysPlayed.Count)
            {
                new Weather();
                player.inventory.DisplayCurrentInventory();
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
                daysPlayed[0].weather.DisplayWeather();
                player.inventory.DisplayCurrentInventory();
                Console.ReadKey();
                player.recipe.DisplayCurrentRecipe();
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
                        break;
                }
                DisplayCustomers();
                i++;
                Console.Clear();
            }

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
            void DisplayCustomers()
            {
                Console.WriteLine("Number of customers Today " + AmountOfCustomers.Count);
                Console.ReadKey();
            }
        }
    }
}



