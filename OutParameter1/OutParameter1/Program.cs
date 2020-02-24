using System;

namespace OutParameter1
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.SayHello();

            Operations ops = new Operations();

            Console.WriteLine("Please enter a number: ");

            int tui = Convert.ToInt32(Console.ReadLine());

            ops.myDoing(tui);

            Console.ReadLine();
        }
    }
}
    
