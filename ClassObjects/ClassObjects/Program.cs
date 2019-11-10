using System;

namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert an integer which is greater 2: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Operations results = new Operations();

            Console.WriteLine("My addition: " + results.Addition(x) + " My substraction:  " + results.Substraction(x) + " My multiplication: " + results.Multiplication(x));

            Console.ReadLine();

        }
    }

}

            
        



