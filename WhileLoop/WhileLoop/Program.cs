using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my age!");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = age == 50;

            while (!isGuessed)
            {
                switch (age)
                {
                    case 45:
                        Console.WriteLine("Your suggestion is 45. Please try it again!");
                        Console.WriteLine("Guess my age!");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 65:
                        Console.WriteLine("Your suggestion is 65. Please try it again!");
                        Console.WriteLine("Guess my age!");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 50:
                        Console.WriteLine("Your suggestion is 50. That's correct!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Your suggestion is not correct");
                        Console.WriteLine("Guess my age!");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            Console.Read();

        }
    }
}
