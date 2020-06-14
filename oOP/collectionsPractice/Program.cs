using System;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        int[] numArray = {0,1,2,3,4,6,7,8,9};
        string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};

        string[] trueFalse = new string[] {true, false, true, false, true, false, true, false, true, false}

        List<string> iceCream = new List<string>();
        //Use the Add function in a similar fashion to push
        iceCream.Add("Neopolitan");
        iceCream.Add("Oreo");
        iceCream.Add("Chocolate");
        iceCream.Add("Vanilla");
        iceCream.Add("Strawberry");
        iceCream.Add("Moca");

        Console.WriteLine(iceCream.Count); 
        Console.WriteLine(iceCream[2]);
        iceCream.Remove("Chocolate");
        Console.WriteLine(iceCream.Count); 

        Dictionary<string,string> profile = new Dictionary<string,string>();
        
            foreach (var name in names)
            {
                nameKeys.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in names)
            {
                int randInx = rand.Next(flavors.Count - 1);
                nameKeys[name] = flavors[randInx];
                flavors.RemoveAt(randInx);
            }

            foreach (var entry in nameKeys)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }

    }
}
