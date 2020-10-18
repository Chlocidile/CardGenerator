using System;
using System.Security.Cryptography.X509Certificates;

namespace CardGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (var i = 1; i <= 7; i++)
            {
                var randomSuit = (Suit)random.Next(0, 4);
                var randomNum = random.Next(0, 14);
                var card = new Card(randomSuit, randomNum);
                Console.WriteLine(card);
            }
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
