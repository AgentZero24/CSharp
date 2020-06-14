using System;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet World = new Buffet();
            Ninja Paul = new Ninja();
            while (!Paul.IsFull)
            {
                Paul.Eat(World.Serve());
            }
        }
        public Card Deal()
        {
            Card returnCards = cards[0];
            cards.RemoveAt(0);
            return returnCards;
        }

        public void Shuffle()
        {
            for (var i = 0; i < cards.Count; i++)
            {
                int randIndex = rand.Next(cards.Count);
                Card temp = cards[0];
                cards[0] = cards[randIndex];
                cards[randIndex] = temp;
            }
        }

        public void Reset()
        {
            Reset();
        }
    }
}
