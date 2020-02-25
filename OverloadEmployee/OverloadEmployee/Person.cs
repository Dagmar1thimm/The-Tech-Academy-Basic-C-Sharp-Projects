using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadEmployee
{
    public class Person
    {

        private string FirstName;
        private string LastName;

        public void sayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }

        public void setFullName(string FN, string LN)
        {

            FirstName = FN;
            LastName = LN;

        }
    }
}
