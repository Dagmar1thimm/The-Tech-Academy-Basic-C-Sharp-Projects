using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            int weight = 50;
            int sum = 50;

            Console.WriteLine("Please enter the package myWeight:");
            int myWeight = Convert.ToInt32(Console.ReadLine());

            if (myWeight > weight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else if (myWeight <= weight)

            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package heigth:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int quote = (width + height + length * myWeight / 100);

                string result = width + height + length > sum ? "Package too big to be shipped via Package Express. " : "Your estimated total for shipping this package is: " + "$" + quote;

                Console.WriteLine(result);
                Console.ReadLine();
               
            }

           Console.WriteLine("Thank you");
        }
                   
    }
            
}
 
