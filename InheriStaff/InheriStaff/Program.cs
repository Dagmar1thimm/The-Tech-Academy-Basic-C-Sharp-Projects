using System;

namespace InheriStaff
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourFN1 = "Sample";
            string yourLN1 = "Student";
            int yourId = 1;

            Employee specEmployee = new Employee();
            specEmployee.setEmployeeId(yourId);

            specEmployee.setFullName(yourFN1, yourLN1);

            specEmployee.sayName();
        }
    }
}
