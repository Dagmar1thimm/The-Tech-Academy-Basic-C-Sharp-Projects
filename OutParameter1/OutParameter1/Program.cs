using System;

namespace OutParameter1
{
        class Program
        {
            static void Main(string[] args)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                Operations results = new Operations();

                Console.WriteLine("Outcome is " + results);


                Console.ReadLine();
            }


        public void getValue(out n)

        {
            Operations n = new Operations();

            int a = 100;

            Console.WriteLine("Get OUT parameter, value of {0}", a);

            n.getValue(out a);
        }

    }
}
}
    }
}
