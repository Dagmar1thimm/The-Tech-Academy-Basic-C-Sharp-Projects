using System;

namespace Method
{
    class Program
    {


        static void Main(string[] args)
        {

            int x = 5;
            int y = 6;

            VoidM results = new VoidM();
          
            Console.WriteLine("My first number: " + results.Math(x) + " My second number:  " + results.Screen(y));
            
          
        }   

           
    }
}

