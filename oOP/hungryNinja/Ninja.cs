using System;
using System.Collections.Generic;
class Ninja
{
    private int calorieIntake;
    private int calorieLimit;
    public List<Food> FoodHistory;

    public bool IsFull{
            get{
                return calorieIntake >= calorieLimit;
            }
        }
    public Ninja(int calories)
        {
            calorieIntake = 0;
            calorieLimit = 3300;
            FoodHistory  = new List<Food>();
        }

    public void Eat(Food item)
    {
        if (this.IsFull)
        {
            Console.WriteLine("Ugh I ate too much");
        }
        else
        {
            Console.WriteLine($"Time to Eat Noms {item.Name}");
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
        }
    }
}
