using System;
using System.Globalization;

namespace CSharp_Day002_TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tip calculator!");
            Console.WriteLine();

            Console.Write("What is the total bill? ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.Write("What percentage tip would you live to give? ");
            double percentage = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("How many people to split the bill? ");
            double people = Convert.ToInt16(Console.ReadLine());

            string portion = String.Format("{0:0.00}", (total + (total * percentage)) / people);
            Console.WriteLine("Each person should pay: $" + portion);
        }
    }
}
