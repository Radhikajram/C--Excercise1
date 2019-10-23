using System;
using System.Collections.Generic;
using System.Text;

namespace Restarunt
{
    public class Empdetails

    {
        public Empdetails()
        {
            empStack = new List<Employee>();
        }
        public void addEmployee(Employee empAdd)
        {
            empStack.Add(empAdd);
        }

        public void displayEmployee()
        {
            foreach (var emp in empStack)
            {
                Console.WriteLine($"First Name : {emp.getFirstName()}");
                Console.WriteLine(emp.getLastName());
                Console.WriteLine(emp.getSalary());
                Console.WriteLine("----------------------");

            }
        }
        private List<Employee> empStack;
    }
}
