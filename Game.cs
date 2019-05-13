﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //has a 
        public List<Day> daysPlayed;
        public Store store;
        public Player player;
        public int i;
        public Random randoCalrissian;
        public Customer customer;
        public Pitcher pitcher;
        public Game game;
        public List<double> noOfCustomersBought;


        // public Day day;



        //spawner
        public Game()
        {
            randoCalrissian = new Random();
            i = 0;
            daysPlayed = new List<Day>();
            player = new Player();
            store = new Store();
            RunGame(noOfCustomersBought);
        }

        //can do

        public void RunGame(List<double> noOfCustomersBought)
        {
            Start();
            GetDays();
            while (i <= daysPlayed.Count - 1)

            {
                Console.WriteLine("day " + (i + 1));
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
                daysPlayed[i].weather.DisplayWeather();
                player.inventory.DisplayCurrentInventory();
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

                pitcher = new Pitcher(player, player.recipe, daysPlayed, noOfCustomersBought);
                if (pitcher.cupsToPitcher == 10)
                {
                    
                    DisplayCustomers();
                    daysPlayed[i].SellLemonade(player, pitcher);
                    daysPlayed[i].EndDay(noOfCustomersBought);
                    i++;
                    Console.Clear();
                }
                else if(pitcher.cupsToPitcher == 0)
                {
                    pitcher.InventoryCheck(player, daysPlayed, noOfCustomersBought);
                    pitcher = new Pitcher(player, player.recipe, daysPlayed, noOfCustomersBought);
                    daysPlayed[i].EndDay(noOfCustomersBought);
                    i++;
                    Console.Clear();
                }
            }
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
                        Day day1 = new Day(randoCalrissian);
                        daysPlayed.Add(day1);
                    }
                    break;
                case "14":
                    while (daysPlayed.Count < 14)
                    {
                        Day day1 = new Day(randoCalrissian);
                        daysPlayed.Add(day1);
                    }
                    break;
                case "30":
                    while (daysPlayed.Count < 30)
                    {
                        Day day1 = new Day(randoCalrissian);
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
            Console.WriteLine("Number of customers Today " + daysPlayed[i].customer.AmountOfCustomers.Count);
            Console.ReadKey();
        }
    }
   
}





