using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello World!";
            string partToLookFor = "hello";


            bool isThere;

            isThere = HelloWorld.ToLower().Contains(partToLookFor);
        
            if(isThere)
            {
                Console.WriteLine($"Leidsin {partToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leidnud {partToLookFor}");
            }


        }
    }
}
