using System;
using CardDeck;
using System.Collections.Generic;
namespace CardDeck
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            deck.Display();
        }
    }
}   
