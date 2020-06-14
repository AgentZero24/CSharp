using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck NewDeck = new Deck();
            NewDeck.Shuffle();
            Player me = new Player("Paul");
            Console.WriteLine(NewDeck.cards.Count);
            me.Draw(NewDeck);
            me.Draw(NewDeck);
            me.Draw(NewDeck);
            me.Draw(NewDeck);
            me.Draw(NewDeck);
            foreach (Card c in me.hand)
            {
                c.Show();
            }
            me.Discard(0);
            me.Discard(3);
            Console.WriteLine(NewDeck.cards.Count);
            foreach (Card c in me.hand)
            {
                c.Show();
            }
        }
    }
}
