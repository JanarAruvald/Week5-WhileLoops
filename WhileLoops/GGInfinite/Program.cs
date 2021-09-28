using System;

namespace GGInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Random = rnd.Next(1, 11);
           

            while (true)
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
                    
                    Console.WriteLine("Proovi uuesti!");
                }


            }
        }
    }
}
