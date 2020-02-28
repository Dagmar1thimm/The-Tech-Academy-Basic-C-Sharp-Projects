using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaEmployee
{
    public class Employee
    {
        public int Id;
        public string firstname;
        public string lastname;

        public Employee(int id, string fn, string ln)
        {
            this.Id = id;
            this.firstname = fn;
            this.lastname = ln;
        }
    }
}
