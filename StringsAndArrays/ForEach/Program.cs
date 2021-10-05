using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            int counter = 0;

            foreach(char character in helloWorld)
            {
                counter = counter + 1; 
                //counter++;
            }

            Console.WriteLine($"{helloWorld} on {counter} sümbolit pikk.");

        }
    }
}
