using System;

namespace NinjaWizardSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Strength = 50;
            Intelligence = 22;
            Dexterity = 175;
            health = 100;
        }

        public Ninja(string name, int strength, int intelligence, int dexterity, int hp) : base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        // Build Attack method
        public int Attack(Ninja target)
        {
            var dmg = new Random().Next(5 * Dexterity, 885);
            Human enemy = (Human)target;
            target.health -= dmg;
            Console.WriteLine($"Ninja attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void Steal(Object target)
        {
            Human enemy = (Human)target;
            enemy.health -= 5;
            health += 5;
        }
    }
}

