using System;

namespace FullNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();

            for (int i = Firstname.Length - 1; i >= 0; i--)
            {
                Console.Write(Firstname[i]);

            }
            for (int i = Firstname.Length + 1; i >= 0; i--)
            {
                Console.Write(LastName[i]);

            }
        }
    }
}
