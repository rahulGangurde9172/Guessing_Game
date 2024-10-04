using QuesGame;
using System;

namespace QuesGame
{
    class Quess
    {
        private int PCrandom;

        public Quess()
        {
            Random random = new Random();
            PCrandom = random.Next(1, 11);
        }

        public int randomNumber
        {
            get
            {
                return PCrandom;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Quess quess = new Quess();
            int pcRandom = quess.randomNumber;

            Console.WriteLine("Welcome to the Guessing Game!! You have only 5 chances.");

            bool isGuessing = true;
            int maxChances = 5;
            int attempts = 0;
            int totalAttempts = 0;

            while (isGuessing && maxChances > attempts)
            {
                Console.WriteLine("Enter your guess (1 - 10): ");
                int guessNumber = int.Parse(Console.ReadLine());
                attempts++;
                totalAttempts++;

                if (pcRandom == guessNumber)
                {
                    Console.WriteLine($"Ohh You Won in {totalAttempts} attempts!! Nice guess, the random number is {pcRandom}");
                    isGuessing = false;
                }
                else if (pcRandom < guessNumber)
                {
                    Console.WriteLine("Your guess is too big.");
                }
                else if (pcRandom > guessNumber)
                {
                    Console.WriteLine("Your guess is too small.");
                }

                if (maxChances == attempts && isGuessing)
                {
                    Console.WriteLine();
                    Console.WriteLine("Chances over! Sorry!! You lost the game.");
                    Console.WriteLine($"The correct number was {pcRandom}.");
                    isGuessing = false;
                }
            }

            Console.ReadLine();
        }
    }
}
