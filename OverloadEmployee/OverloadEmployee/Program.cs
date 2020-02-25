using System;

namespace OverloadEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourFN1 = "Sample";
            string yourLN1 = "Student";
            int yourId1 = 1;

            string yourFN2 = "Bob";
            string yourLN2 = "Myer";
            int yourId2 = 2;

            Employee oneEmployee = new Employee();
            oneEmployee.setEmployeeId(yourId1);

            oneEmployee.setFullName(yourFN1, yourLN1);

            Employee employeeTwo = new Employee();
            employeeTwo.setEmployeeId(yourId2);
            employeeTwo.setFullName(yourFN2, yourLN2);

            Console.WriteLine("Employee 1: Id = " + oneEmployee.getId());
            oneEmployee.sayName();
            Console.WriteLine("Employee 2: Id = " + employeeTwo.getId());
            employeeTwo.sayName();
            Console.WriteLine("Employees are identical: " + (oneEmployee == employeeTwo));
            Console.WriteLine("Employees are different: " + (oneEmployee != employeeTwo));
            Console.ReadLine();
        }
    }
}
