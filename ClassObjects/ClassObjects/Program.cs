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
            Console.WriteLine("My addition: " + results.addition + "My substraction:  " + results.substraction + "My multiplication: " + results.multiplication);

            Console.ReadLine();

        }
    }

}

            
        



