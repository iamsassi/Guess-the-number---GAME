using System;

namespace Guess_the_number___GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            int guess = 0;
            string answer;
            bool loop = true;

            while (loop)
            {
                Console.Write("> ");
                answer = Console.ReadLine();

                try
                {
                    if (int.Parse(answer) == theNumber)
                    {
                        guess++;
                        Console.WriteLine($"Congratulations you guessed right, after {guess} number of attemps");
                        loop = false;
                    }
                    else if (int.Parse(answer) == -1) // the user have chosen to exit the game
                    {
                        loop = false;
                    }
                    else
                    {
                        if (int.Parse(answer) < theNumber)
                        {
                            guess++;
                            Console.WriteLine($"Guess a higher number, you have guessed {guess}");

                        }
                        else
                        {
                            guess++;
                            Console.WriteLine($"Guess a lower number, you have guessed {guess}");

                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please typ a number");
                }
            }

            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

            Console.ReadLine();
        }
    }
}
