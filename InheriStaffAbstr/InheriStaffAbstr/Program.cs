using System;

namespace InheriStaffAbstr
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourFN1 = "Sample";
            string yourLN1 = "Student";

            Employee specEmployee = new Employee();

            specEmployee.setFirstName(yourFN1);
            specEmployee.setLastName(yourLN1);

            specEmployee.sayName();
        }
    }
}
