using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Employee
    {
        private string Role;
        private double Salary;


        public Employee()
        {
        }

        public Employee(string Role, double Salary)
        {
            this.Role = Role;
            this.Salary = Salary;

        }


        public void SetRole(string Role) { this.Role = Role; }

        public string GetRole() { return Role; }

        public void SetSalary(double Salary) { this.Salary = Salary; }

        public double GetSalary() { return Salary; }
    }
}
