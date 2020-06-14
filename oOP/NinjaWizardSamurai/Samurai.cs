using System;

namespace NinjaWizardSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Strength = 100;
            Intelligence = 22;
            Dexterity = 50;
            health = 200;
        }

        public Samurai(string name, int strength, int intelligence, int dexterity, int hp) : base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        // Build Attack method
        public void Attack(Object target)
        {
            Human enemy = (Human)target;
            if (enemy.health <= 50)
            {
                enemy.health = 0;
                Console.WriteLine($"Samurai has killed {enemy.Name} with his blade.");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} dodged {Name}'s attack.");
            }
        }

        public void Meditate()
        {
            health = 200;
        }
    }
}

