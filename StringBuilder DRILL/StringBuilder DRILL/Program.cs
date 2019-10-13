using System;
using System.Text;

namespace StringBuilder_DRILL
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Dagmar lives in CET timezone. ");
            sb.Append("Hans, too.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
