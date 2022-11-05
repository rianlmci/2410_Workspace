using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStruct

{
    public enum Suit { Spades = 9824, Clubs = 9827, Hearts = 9829, Diamonds = 9830 }

    public enum Rank { Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Joker, Queen, King, Ace }

    public struct Card
    {
        public Rank Rank {get;} //read-only = getter and caps makes it a property, structs are read only!
        public Suit Suit {get;} 

        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }
        public override string ToString()
        {
            return $"{(char)Suit} {Rank}"; 
        }
    }
}
