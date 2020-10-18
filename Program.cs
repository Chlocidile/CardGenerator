using System;

namespace CardGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(Suit.Spades, 1);
            
            Console.WriteLine(card);
        }
    }

    public enum Suit
    {
        Hearts = 0,
        Diamonds = 1,
        Spades = 2,
        Clubs = 3,
    }
    
    public class Card
    {
        public Suit Suit { get; }
        public int Value { get; }
        
        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
