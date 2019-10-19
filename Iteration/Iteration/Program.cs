using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "cherry", "dattes", "blueberries", "blackberries" };
            Console.WriteLine("Please enter your preference: ");
            int index = int.Parse(Console.ReadLine());

            for (index = 0; index < fruits.Length; index++)
            {
                
                Console.WriteLine("My preference is: " + fruits[index]);
            }
            Console.ReadLine();
        



        }
    }
}
