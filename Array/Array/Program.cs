﻿using System;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string [] name = new string [5] { "Frank", "Beth", "Juan" , "Dave", "Leila" };

            Console.WriteLine("Enter your number between 0-4:");
            int myName = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is: " + name[myName]);

            

            int[] number = { 4, 3, 9, 1, 2 };
            
            Console.WriteLine("Enter your number between 0 - 4:");
            int index = int.Parse(Console.ReadLine());


            
            if (index < number.Length && index >= 0)
            {
                Console.WriteLine("Your preferd number is: " + number[index]);
            }

            else 
            {
                Console.WriteLine("Wrong entry, Please enter a lower number");
            }
            Console.ReadLine();

            List<string> intList = new List<string>();
            intList.Add ("Hans");
            intList.Add("John");
            intList.Add("Leila");

            Console.WriteLine("Enter your number 0-2:");
            int friend = int.Parse(Console.ReadLine());
            Console.WriteLine("Your friend is: " + intList[friend]);
        }

        }
    }

    