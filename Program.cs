using System;

namespace Restarunt
{
    class Program
    {
        //Testchange
        static void Main(string[] args)
        {
            // Input the Employee details.

            var employee1 = new Employee("Radhika", "Jayaraman", 5000);
            var employee2 = new Employee("James", "Bond", 6000);
            var employee3 = new Employee("Mickel", "Jackson", 10000);

            // Store the Employee Information 

            var empInformation = new Empdetails();

            //Add New Employee to the stack
            empInformation.addEmployee(employee1);
            empInformation.addEmployee(employee2);
            empInformation.addEmployee(employee3);

            //display all the employees,
            empInformation.displayEmployee();

           


        }
    }
}
