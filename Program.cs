using System;

namespace inlämningsuppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill di hyra en Firari");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer ska du köra?");
            float Y = float.Parse(Console.ReadLine());
            float Z = 300 + 1 * Y + 500 * X - 500;
            Console.WriteLine("Totalt pris " + Z + " kronor ");
        }
    }
}