using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSelection
{
    class Employee
    {
        public string Name;
        public string City;
        public int Salary; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            var employees = new List<Employee>
            {
                new Employee { Name = "Ashis", City = "Kathmandu", Salary = 50000 },
                new Employee { Name = "Samyog", City = "Pokhara", Salary = 60000 },
                new Employee { Name = "Ashok", City = "Kathmandu", Salary = 30000 },
                new Employee { Name = "Sudhan", City = "Lalitpur", Salary = 8000 },
                new Employee { Name = "Hikmat", City = "Kathmandu", Salary = 20000 }
            };

            // Use LINQ to select employees who live in Kathmandu and have a salary greater than 10000
            var eligibleEmployees = from e in employees
                                    where e.City == "Kathmandu" && e.Salary > 10000
                                    select e;

            // Print the names of the selected employees
            foreach (var employee in eligibleEmployees)
            {
                Console.WriteLine($"{ employee.Name}\t{ employee.City}\t{ employee.Salary}");
            }
        }
    }
}
