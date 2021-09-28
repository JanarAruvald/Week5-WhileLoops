using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            
            while(true)
            {
                Console.WriteLine("Sisesta number:");
                int UserGuess = Convert.ToInt32(Console.ReadLine());

                if(cpuRandom == UserGuess)
                {
                    Console.WriteLine("Tubli! Oled mängu võitnud!");
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
