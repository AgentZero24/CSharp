using System;

namespace NinjaWizardSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Samurai("Mike");
            var player2 = new Ninja("Paul");
            var player3 = new Wizard("Nick");
            Console.WriteLine(player1.Name);
            Console.WriteLine(player2.Name);
            Console.WriteLine(player3.Name);
            player2.Attack(player1);
            player3.Heal(player2.Name);
            player2.Steal(player3.Name);
            player1.Meditate();
            Console.WriteLine(player1.Name);
            Console.WriteLine(player2.Name);
        }
    }
}
