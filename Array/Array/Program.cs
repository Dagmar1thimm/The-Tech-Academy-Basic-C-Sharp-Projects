using System;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main()
        {
            string[] strArr = new string[] { "Fred", "Steve", "Carla", "Curt", "Julia" };
            Console.WriteLine("Who is the expert for coding in your perspective?");


            Console.WriteLine(strArr[3]);
            Console.ReadLine();




            int[] numArr = { 4, 3, 9, 1, 2 };
            int i = 3;
            Console.WriteLine("Which number do you prefer?");
            Console.WriteLine(numArr[i]);
            Console.ReadLine();

            
            i = 7;
            if (i > numArr.Length)
     
               {
                Console.WriteLine("Wrong entry, Please enter a lower number");
            }
            Console.ReadLine();

            List<string> intList = new List<string>();
            intList.Add ("Hi");
            intList.Add("John");
            intList.Add("Leila");
            Console.WriteLine(intList[2]);
            Console.ReadLine();
        }

        }
    }

    