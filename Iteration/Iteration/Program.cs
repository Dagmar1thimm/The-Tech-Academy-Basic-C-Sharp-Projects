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
          

            for (int index = 0; index < fruits.Length; index++)
            {
                if (index == 0)
                {
                    Console.WriteLine("My preference is: " + fruits[0]);
                }
                else if (index == 1)
                {
                    Console.WriteLine("A nice fruit is: " + fruits[1]);
                }
                else if (index == 2)
                {
                    Console.WriteLine("In spring, you can buy: " + fruits[2]);
                }
                else if (index == 3)
                {
                    Console.WriteLine("This fruit is awesome: " + fruits[3]);
                }
                else 
                {
                    Console.WriteLine("The most healthy fruit is: " + fruits[4]);
                }
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

            //Question 4
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
            Console.WriteLine(Console.ReadLine());

            
                int catIndex = cats.FindIndex(a => a.Contains("cat1"));
                Console.WriteLine("My cat: " + catIndex);

                catIndex = cats.FindIndex(a => a.Contains("cat2"));
                Console.WriteLine("My cat: " + catIndex);

                catIndex = cats.FindIndex(a => a.Contains("cat3"));
                Console.WriteLine("My cat: " + catIndex);

                catIndex = cats.FindIndex(a => a.Contains("cat4"));
                Console.WriteLine("My cat: " + catIndex);

                catIndex = cats.FindIndex(a => a.Contains("cat5"));
                Console.WriteLine("My cat: " + catIndex);

            // if (catIndex < cats.Count)
            // {
            //     Console.WriteLine(Console.ReadLine()[catIndex]);
            // }

            //Question 7
            //else
            // {
            //     Console.WriteLine("Choice is outside the List!");
            // }
            // Console.ReadLine();

            //Question 8
            //???

            //Question 9

            List<string> weekDays = new List<string>{ "Monday", "Tuesday", "Monday", "Friday", "Thursday" };

            for (int j = 0; j < weekDays.Count; j++)
            {
                if (weekDays[j] == "Monday")
                Console.WriteLine(weekDays[j]);
            }
            Console.ReadLine();

            //Question 10
            //if (j > weekDays.Count)
            //{
            //    Console.WriteLine("Not in the list");
            //}

            //Question 11
            List<string> cities = new List<string> { "Portland", "Berlin", "Dallas", "London", "Berlin" };

            int cityPos = cities.Count;

            foreach (string city in cities)
            {
                cityPos = cities.FindIndex(a => a.Contains("Portland"));
                Console.WriteLine("I have never been there ", cityPos);

                cityPos = cities.FindIndex(a => a.Contains("Berlin"));
                Console.WriteLine("Double in the List " + cityPos);

                cityPos = cities.FindIndex(a => a.Contains("Dallas"));
                Console.WriteLine("It was a nice short trip ", cityPos);

                cityPos = cities.FindIndex(a => a.Contains("London"));
                Console.WriteLine("One of the most important places is ", cityPos);

                cityPos = cities.FindIndex(a => a.Contains("Berlin"));
                Console.WriteLine("Double in the List ", cityPos);
            }
            Console.ReadLine();


        }
    }
}
