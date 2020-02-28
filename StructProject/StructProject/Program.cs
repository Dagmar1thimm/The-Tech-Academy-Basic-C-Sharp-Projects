using System;

namespace StructProject
{
    class Program
    {
        public struct Number
        {
            public decimal amount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");

            Number myNumber;

            myNumber.amount = (decimal) 1.2;

            Console.WriteLine("The amount is: " + myNumber.amount);
            Console.ReadLine();
        }
    }
}
