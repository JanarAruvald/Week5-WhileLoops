using System;

namespace Küpsisetort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cookies wide is the cake?");
            int CWide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cookies in lenght is the cake?");
            int CLong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many layers does the cake have?");
            int CLayer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cookies in a pack of cookies?");
            int CPack = Convert.ToInt32(Console.ReadLine());
            int CArea = CLong * CWide;
            int CAll = CLayer * CArea;
            int CPAll = Convert.ToInt32(Math.Round((double)CAll / CPack));
            Console.WriteLine($"You need {CPAll} packs of cookies");










        }
    }
}
