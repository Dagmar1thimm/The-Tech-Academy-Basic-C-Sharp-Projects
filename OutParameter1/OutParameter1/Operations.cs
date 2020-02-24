using System;
using System.Collections.Generic;
using System.Text;

namespace OutParameter1
{
    class Operations
    {
        public void myDoing(int num1)

        {

            int val = num1 / 2;

            Console.WriteLine("The operation result is: " + val);

            Console.ReadLine();

        }

        public void myDoing(float num1)

        {

            float val = (num1) / 2;

            Console.WriteLine("The operation result is: " + val);

            Console.ReadLine();

        }
    }
   
}
