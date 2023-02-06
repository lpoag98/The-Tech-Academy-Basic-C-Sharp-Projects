using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_1
{
    public class Card
    { 
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; } 
    }
}
