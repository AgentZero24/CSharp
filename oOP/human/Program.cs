using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {

            var player1 = new Human("1337");
            var player2 = new Human("Nub");
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            player2.Attack(player1);
        }
    }
}
