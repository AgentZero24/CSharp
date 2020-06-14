using System;
using System.Diagnostics;

class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    // // public string health
    // {
    //     get
    //     {
    //         return health;
    //     }// add a public "getter" property to access health
    // }
     

    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    } // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     
    // public Stats(string name, int Strength, int Intelligence, int Dexterity, int health)
    // {
    //     if (Name is null)
    //     {
    //         throw new System.ArgumentNullException(nameof(Name));
    //     }

    //     Name = name;
    //     Strength = 3;
    //     Intelligence = 3;
    //     Dexterity = 3;
    //     health = 100;

        
    // }// Add a constructor to assign custom values to all fields
     
    // Build Attack method
    public void Attack(Object victim)
    {
        var Vic = (Human) victim;
        Vic.health -= 5 * Strength;
        Console.WriteLine($"{Vic.Name} loses {5 * Strength} pts from health.");
    }
}

