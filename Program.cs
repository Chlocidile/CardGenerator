using System;

namespace CardGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputIsValidated = false;
            var numOfCards = 0;

            while (inputIsValidated == false)
            {
                Console.WriteLine("How many random cards do you want?");
                var userChoice = Console.ReadLine();

                if (!int.TryParse(userChoice, out numOfCards))
                {
                    Console.WriteLine("Please type a number :)");
                    continue;
                }

                inputIsValidated = true;
            }

            var random = new Random();

            for (var i = 1; i <= numOfCards; i++)
            {
                var randomSuit = (Suit)random.Next(0, 4);
                var randomNum = random.Next(1, 14);
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
            return this switch
            {
                { Value: 1 } => $"Ace of {Suit}",
                { Value: 11 } => $"Jack of {Suit}",
                { Value: 12 } => $"Queen of {Suit}",
                { Value: 13 } => $"King of {Suit}",
                _ => $"{Value} of {Suit}",
            };
        }
    }
}
