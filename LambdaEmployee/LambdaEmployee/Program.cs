using System;
using System.Collections.Generic;


namespace LambdaEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee(1, "Willie", "Smith"));
            employeeList.Add(new Employee(2, "Joe", "Miller"));
            employeeList.Add(new Employee(3, "Sam", "Big"));
            employeeList.Add(new Employee(4, "Robert", "Small"));
            employeeList.Add(new Employee(5, "Judy", "Winter"));
            employeeList.Add(new Employee(6, "Mary", "Nice"));
            employeeList.Add(new Employee(7, "Carla", "Lean"));
            employeeList.Add(new Employee(8, "Elon", "Musk"));
            employeeList.Add(new Employee(9, "Joe", "Little"));
            employeeList.Add(new Employee(10, "Burt", "Whiskey"));

            Console.WriteLine("The list of employees is as follows:");
            foreach (Employee e in employeeList)
            {
                Console.WriteLine(e.Id + ": " + e.firstname + ", " + e.lastname);
            }
            Console.WriteLine("Please press ENTER");
            Console.ReadLine();

            List<Employee> joeList = new List<Employee>();

            foreach (Employee e in employeeList)
            {
                if (e.firstname == "Joe")
                {
                    joeList.Add(e);
                }
            }

            List<Employee> joeListLambda = new List<Employee>();

            joeListLambda = employeeList.FindAll(e => (e.firstname == "Joe"));

            Console.WriteLine("The list of joes without lambda:");
            foreach (Employee e in joeList)
            {
                Console.WriteLine(e.Id + ": " + e.firstname + ", " + e.lastname);
            }

            Console.WriteLine("The list of joes using lambda:");
            foreach (Employee e in joeListLambda)
            {
                Console.WriteLine(e.Id + ": " + e.firstname + ", " + e.lastname);
            }

            Console.WriteLine("Please press ENTER");
            Console.ReadLine();


            List<Employee> greater5ListLambda = new List<Employee>();

            greater5ListLambda = employeeList.FindAll(e => (e.Id > 5));

            Console.WriteLine("The list of employees with id > 5:");
            foreach (Employee e in greater5ListLambda)
            {
                Console.WriteLine(e.Id + ": " + e.firstname + ", " + e.lastname);
            }

            Console.WriteLine("Please press ENTER to finish.");
            Console.ReadLine();

        }
        /*
        foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())  
        {  
            Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);  
        }
*/
    }
}
