using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{ 
class Demand
{
    //member variables
    public int priceDemand;
    public int weatherDemand;

    //constructor
    public Demand()
    {

    }

    //can do
    public int GetPriceDemand(Recipe recipe)
    {
        if (recipe.lemonadePrice <= .25)
        {
            priceDemand = 1;
        }
        else if (recipe.lemonadePrice >= .26 && recipe.lemonadePrice <= .50)
        {
            priceDemand = 2;
        }
        else if (recipe.lemonadePrice >= .51 && recipe.lemonadePrice <= .75)
        {
            priceDemand = 3;
        }
        else if (recipe.lemonadePrice >= .76)
        {
            priceDemand = 4;
        }
        return priceDemand;
    }
    public int GetWeatherDemand(Weather weather)
    {
        if (weather.currentCondition == "sunny")
        {
            weatherDemand = 1;
        }
        else if (weather.currentCondition == "muggy")
        {
            weatherDemand = 2;
        }
        else if (weather.currentCondition == "cloudy")
        {
            weatherDemand = 3;
        }
        else if (weather.currentCondition == "raining")
        {
            weatherDemand = 4;
        }
        return weatherDemand;
    }


}

}
