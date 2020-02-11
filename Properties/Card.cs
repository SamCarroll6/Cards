using System;
using System.Collections.Generic;
namespace CardDeck
{
    public class Card
    {
        public String Name { get; set; }
        public String Suit { get; set; }
        public int Value { get; set; }
        public Card(String name1, String suit1, int value1)
        {
            Name = name1;
            Suit = suit1;
            Value = value1;
        }

        public override String ToString()
        {
            return Name + " of " + Suit + " has a value of " + Value;
        }
    }
}
