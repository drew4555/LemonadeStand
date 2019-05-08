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





        //spawner
        public Game()
        {
            daysPlayed = new List<Day>();
        }
        //can do
        public void RunGame()
        {
            Start();
            GetDays();
            player = new Player();
            store = new Store();
            Console.WriteLine("Do you want to go to store?");
            string shop = Console.ReadLine().ToLower();
            switch (shop)
            {
                case "yes":
                    {
                        store.DisplayPrices();
                        store.Shopping(player);
                        store.ContinueShopping(player);
                        break;
                    }
                case "no":
                    {
                        break;
                    }
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
        }
    }



