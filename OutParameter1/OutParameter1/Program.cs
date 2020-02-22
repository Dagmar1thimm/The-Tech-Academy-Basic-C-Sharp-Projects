using System;

namespace OutParameter1
{
        class Program
        {
            static void Main(string[] args)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                Operations results = new Operations();

                Console.WriteLine("Outcome is " + results.Div(x));


                Console.ReadLine();
            }
        }
    }
}
    }
}
