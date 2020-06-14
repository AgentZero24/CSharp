using System;

namespace NinjaWizardSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            {
                Name = name;
                Strength = 1;
                Intelligence = 25;
                Dexterity = 80;
                health = 50;
            }
        }
        public Wizard(string name, int strength, int intelligence, int dexterity, int hp) : base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }
        public void Attack(Object target)
        {
            int dmg = Intelligence * 5;
            Human enemy = (Human)target;
            enemy.health -= dmg;
            health += dmg;
            Console.WriteLine($"Wizard healed themselves for {dmg} health points");
            Console.WriteLine($"Wizard attacked {enemy.Name} for {dmg} damage!");
        }
        public void Heal(Object target)
        {
            int heal = 10 * Intelligence;
            Human healed = (Human)target;
            healed.health += heal;
            Console.WriteLine($"Wizard has healed {healed.Name} by {heal}.");
        }

    }
}

