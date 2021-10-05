using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string Firstname = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();

            string FullName = $"{Firstname}{LastName}".ToLower();

            /*foreach(char character in FullName)
            {
                if(character == 'a')
                {
                    counter++;
                }
               
            }*/

            /*while(i >= 0)
            {
                Console.WriteLine(FullName[i]);

                if (FullName[i] == 'a')
                {
                    counter++;
                }

                i--;
            }*/

            int counter = 0;

            for (int i = 0; i < FullName.Length; i++)
            {
                if(FullName[i] == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte.");




        }
    }
}
