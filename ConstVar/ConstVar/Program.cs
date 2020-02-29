using System;

namespace ConstVar
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const int c = 5;

            var i = 7;

            i += c;

            Console.WriteLine("The value is: " + i);

            Chaining chain0 = new Chaining("bla");

            Chaining chain1 = new Chaining(3);

            Chaining chain2 = new Chaining();
            chain2.setNumber(3);
            chain2.setString("ljkhlkjh");

            chain0.printMe();
            chain1.printMe();
            chain2.printMe();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }


    }
}
