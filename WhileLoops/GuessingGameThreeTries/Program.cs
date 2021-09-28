using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Random = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta number:");
                int UserGuess = Convert.ToInt32(Console.ReadLine());

                if (Random == UserGuess)
                {
                    Console.WriteLine("Arvasid õigesti!");
                    break;
                }
                else
                {
                    i++; //i = i + 1
                    Console.WriteLine($"Proovi uuesti!{3 - i} katset on jäänud.");
                }


            }
        }
    }
}
