using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimi on {Firstname.Length} ja perekonnanimi on {LastName.Length}");

            if(Firstname.Length > LastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem, kui su perekonnanimi.");

            }
            else if(Firstname.Length < LastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem, kui su eesnimi.");

            }
            else
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on sama pikad.");
            }
        }
    }
}
