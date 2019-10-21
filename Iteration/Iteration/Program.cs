using System;
using System.Collections.Generic;
using System.Linq;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            string[] fruits = { "banana", "apple", "cherry", "dattes", "blueberries" };

            Console.WriteLine("Please enter your evaluation of the various fruits: ");

            string name = Console.ReadLine();
            Console.WriteLine("User input is: " + name);

            for (int index = 0; index < fruits.Length; index++)
            {

                    Console.WriteLine("My preference is: " + fruits[index] + name);

            }

            Console.ReadLine();

            //Question 2
            int weeks = 52;
            //for (int position = 0; position != weeks; position+=7)
            //{
            //   Console.WriteLine("weeks left: {infinite}");
            //}
            //Console.ReadLine();

            //Question 3
            for (int position = 0; position < weeks; position++) //this is the fix of the infinite loop, please use the previous or this code  
            {
                Console.WriteLine("weeks left: " + position);
            }
            Console.ReadLine();

            ////Question 4
            int[] age = { 34, 24, 90, 45, 67, 65, 56, 50 };
            for (int a = 0; a < age.Length; a++)
            {
               if (age[a] < 50)
                {
                    Console.WriteLine("Your are young: " + age[a]);
                }
            }
            Console.ReadLine();


            //Question 5
            int[] scores = { 78, 240, 90, 45, 67, 65, 56, 50 };
            for (int b = 0; b < scores.Length; b++)
                {
                    if (scores[b] <= 65)
                    {
                        Console.WriteLine("You scored high: " + scores[b]);
                    }

                }
            Console.ReadLine();


            //Question 6
            List<string> cats = new List<string>() { "cat1", "cat2", "cat3", "cat4", "cat5" };


            Console.WriteLine("Chose cat: ");
            string animal = Console.ReadLine();
            bool outList = false;

            for (int i = 0; i < cats.Count; i++)
            {

                if (animal == cats[i])
                {
                    outList = true;
                    Console.WriteLine(i);
                    //break; //Question 8
                }
            }
            Console.WriteLine(outList);


            //Question 7
            if (outList == false)
            {
                Console.WriteLine("Choice is outside the List!");
            }
            Console.ReadLine();


            //Question 9

            List<string> weekDays = new List<string> { "Monday", "Tuesday", "Monday", "Friday", "Thursday" };

            Console.WriteLine("Which day is today: ");
            string choice = Console.ReadLine();

            bool outSide = false;

            for (int j = 0; j < weekDays.Count; j++)
                {
                    if (choice == weekDays[j])
                    {
                        outSide = true;
                        Console.WriteLine(j);
                    }
                    
                }
                Console.WriteLine(outSide);

                //Question 10
                if (outSide == false)
                {
                   Console.WriteLine("Not in the list");
                }
                Console.ReadLine();

                //Question 11

                List<string> cities = new List<string> { "Portland", "Berlin", "Dallas", "London", "Berlin" };
                List<string> uniqueCities = new List<string>{ };
 
                foreach (string city in cities)
                {
                    if (uniqueCities.Contains(city))
                    {
                        Console.WriteLine("This city is already appeared: " + city);
                    }

                    else
                    {
                        uniqueCities.Add(city);
                    }

                }
                Console.ReadLine();
        }
    }
}
