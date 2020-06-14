using System;
using System.Collections.Generic;
class Buffet
{
    public List<Food> Menu;
    public static Random rand = new Random();

     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false)
            new Food("Burger", 2000, false, false)
            new Food("Fries", 1100, false, false)
            new Food("Hot Dog", 1300, false, false)
            new Food("Ice Cream", 1800, false, true)
            new Food("Salsa", 800, true, false)
        };
    }
     
    public Food Serve()
    {
        return Menu[rand.Next(Menu.Count)];s
    }
}
