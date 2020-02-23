using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassIntegers
{
    class Program
    {
        static void Main()
        {
            int val1 = 1;
            int val2 = 2;

            Class1 myThing = new Class1();

            myThing.myMethod(1, 2);

            myThing.myMethod(val1, val2);

        }

    }
    

    
       
    }

