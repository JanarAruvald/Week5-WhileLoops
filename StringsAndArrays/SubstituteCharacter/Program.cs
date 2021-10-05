using System;

namespace SubstituteCharacter
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

            FullName = FullName.Replace('a', '*');

            Console.WriteLine(FullName);



        }
    }
}
