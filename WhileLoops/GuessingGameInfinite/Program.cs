using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a number between 1 and 10");

            int i = 0;

            while (i < 3)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out i))
                {
                    Console.WriteLine("Please use an actual number");

                    continue;
                }
                i = Int32.Parse(input);

                if (i != correctNumber)
                {
                    Console.WriteLine("Wrong number, please try again");
                }
                else { }
            }

            Console.WriteLine("CORRECT!! You guessed it right!");

            






        }
    }
}
