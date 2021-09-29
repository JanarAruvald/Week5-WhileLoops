using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada number
            //programm kuvab korrutustabelit 1 kuni 10 sisestatud numbri jaoks
            // usenumber = 5
            // 1 * 5 = 5
            // 2 * 5 = 10
            //jne

            Console.WriteLine("Input the number (Table to be calculated) : ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 11; i++)
            {            
                Console.WriteLine($"{i} * {UserNumber} = {i * UserNumber}");
            }


        }
    }
}
