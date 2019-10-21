using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wholeNum = new List<int> { 75, 4, 6, 98, 30, 28 };
            try
            {
                Console.WriteLine("Please enter your divider: ");
                int divider = Convert.ToInt32(Console.ReadLine());

                foreach (var item in wholeNum)
                {
                    var result = item / divider;
                    Console.WriteLine(result);
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid format");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
