using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 99; i > 0; i--)
            {
                if (i != 0) 
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. Take one down and pass it around, {i - 1} bottles of beer on the wall");

                }

                else
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. Take one down and pass it around, no more ottles of beer.");
                }
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer: Go to the store and buy some more, 99 bottles of beer on the wall.");

            }
            










        }
    }
}
