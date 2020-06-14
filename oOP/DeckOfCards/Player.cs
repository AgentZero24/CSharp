using System;
using System.Collections.Generic;
using DeckOfCards;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> hand = new List<Card>();

        public Player(string name)
        {
            Name = name;
            hand = new List<Card>();
        }

        public Card Draw(Deck cards)
        {
            hand.Add(cards.Deal());
            return hand[0];
        }


        public Card Discard(int index)
        {
            if (hand.Count > index)
            {
                Card discarded = hand[index];
                hand.Remove(discarded);
                return discarded;
            }
            return null;
        }
    }
}