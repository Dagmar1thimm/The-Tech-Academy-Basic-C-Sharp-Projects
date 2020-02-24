using System;
using System.Collections.Generic;
using System.Text;

namespace InheriStaff
{
    class Employee : Person
    {

        private int Id;
        public void setEmployeeId(int eID)
        {
            Id = eID;
            Console.WriteLine(eID);
        }
    }
}
