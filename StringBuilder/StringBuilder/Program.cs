using System;
using System.Text;

namespace StringBuilder
{
    class StringBuilder
    {
        static void Main()
       
            {

                //string name = "Dagmar";
                //string timezone = "CET";
                //string action = "lives";

                //Console.WriteLine("Hello, " + name + " who " + action + " in the " + timezone + "?");
                //Console.Read();

            StringBuilder sb = new StringBuilder();
            sb.Append("Dagmar");
            sb.Append("lives");
            sb.Append("in");
            sb.Append("CET");

            Console.WriteLine(sb.ToString());
           



            }
       
    }
}

