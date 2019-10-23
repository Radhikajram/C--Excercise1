using System;
using System.Collections.Generic;
using System.Text;

namespace Restarunt
{
    public class Employee
    {
        public Employee(string firstName,string lastName,int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;

        }
        public int getSalary()
        {
            return this.salary;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        private string firstName;
        private string lastName;
        private int salary;
        
    }
}
