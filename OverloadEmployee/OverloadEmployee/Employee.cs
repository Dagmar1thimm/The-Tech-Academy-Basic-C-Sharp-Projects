using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadEmployee
{
    public class Employee : Person
    {

        private int Id;
        public void setEmployeeId(int eID)
        {
            Id = eID;
            // Console.WriteLine(eID);
        }

        public int getId()
        {
            return Id;
        }

        public static bool operator == (Employee e1, Employee e2)
        {

            return (e1.getId() == e2.getId());
        }

        public static bool operator != (Employee e1, Employee e2)
        {

            return (e1.getId() != e2.getId());
        }


    }
}
