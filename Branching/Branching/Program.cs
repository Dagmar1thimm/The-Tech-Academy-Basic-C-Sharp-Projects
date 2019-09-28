using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = 51;
            if (weight > 50);
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            Console.WriteLine("Please enter the package width:");
            int width = 10;
            Console.WriteLine(width);

            Console.WriteLine("Please enter the package heigth:");
            int height = 30;
            Console.WriteLine(height);

            Console.WriteLine("Please enter the package length:");
            int length = 30;
            Console.WriteLine(length);

            if (width + height + length > 50);
            Console.WriteLine("Package too big to be shipped via Package Express.");


            
            decimal sum = (width + height + length * weight / 100);

            Console.WriteLine("Your estimated total for shipping this package is:");
            Console.WriteLine("$" + sum);
            Console.WriteLine("Thank you");

        }
    }
}
