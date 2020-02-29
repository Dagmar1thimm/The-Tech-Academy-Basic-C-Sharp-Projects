using System;

namespace FileTextLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn = "logfile.txt";
            WriteLogFile numUser = new WriteLogFile();

            Console.WriteLine("Please enter your number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            numUser.WriteLog(fn, firstNum.ToString());

            Console.WriteLine("Log is written!");
            Console.ReadLine();

            numUser.PrintLogToConsole(fn);
            Console.ReadLine();
        }
    }
}
