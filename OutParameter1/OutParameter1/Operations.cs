using System;
using System.Collections.Generic;
using System.Text;

namespace OutParameter1
{
    class Operations
    {
        public int Div(int x)
        {

            int results = x / 2;

            return results;

        }


        public void GetValue()
        {
            Operations n = new Operations();

            int a = 100;
            Console.WriteLine("Get OUT parameter, value of {0}", a);

            n.GetValue();
        }
       

    }
}
