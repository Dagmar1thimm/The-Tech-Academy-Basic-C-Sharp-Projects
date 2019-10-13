using System;
using System.Text;

namespace StringBuilder_DRILL
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Dagmar";
            string timezone = "CET";
            string action = "lives";

            Console.WriteLine("Hello, " + name + " who " + action + " in the " + timezone + "?");
            Console.ReadLine();

            name = "Dagmar";
            timezone = "CET";
            action = "lives";
            name = name.ToUpper();
            action = action.ToUpper();
            Console.WriteLine("Hello, " + name + " who " + action + " in the " + timezone + "?");
            Console.ReadLine();

            StringBuilder sb = new StringBuilder("Dagmar lives in CET timezone. ");
            sb.Append("Hans, too.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
