using System;
using System.Collections.Generic;
namespace CardDeck
{
    public class Deck
    {
        private String[] Names = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        private int[] Values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        private String[] Suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
        public Card[] CardDeck;
        private const int NumCards = 52;

        public Deck()
        {
            CardDeck = new Card[NumCards];
            int place = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    CardDeck[place] = new Card(Names[i], Suits[j], Values[i]);
                    place++;
                }
            }
        }

        public void Shuffle()
        {
            Card Hold;
            var rand = new Random();
            int swap1, swap2;
            for (int i = 0; i < 104; i++)
            {
                swap1 = rand.Next(NumCards);
                swap2 = rand.Next(NumCards);
                Hold = CardDeck[swap1];
                CardDeck[swap1] = CardDeck[swap2];
                CardDeck[swap2] = Hold;
            }
        }

        public void Display()
        {
            foreach(var card in CardDeck)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
