using System;
using System.Collections.Generic;
using System.Text;

namespace InheriStaffAbstr
{
    class Employee : PersonAbstr
    {
        public override void sayName()
        {
            Console.WriteLine("Name: ["+ firstName +" "+ lastName +"]");

            Console.ReadLine();
        }
        public override void setFirstName(string FN)
        {
            firstName = FN;
        }
        public override void setLastName(string LN)
        {
            lastName = LN;
        }
    }
}
