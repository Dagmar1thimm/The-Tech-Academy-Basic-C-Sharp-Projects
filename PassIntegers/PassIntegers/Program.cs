using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassIntegers
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please insert the first integer for math: ");
            int x = Convert.ToInt32(Console.ReadLine());
           

            Class1 results = new Class1();

            Console.WriteLine("Here is the math with the first number " + results.Substraction(x));

            Console.WriteLine("Here is the second number " + Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();
        }
       
    }
}
