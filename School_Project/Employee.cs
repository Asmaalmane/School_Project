using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Employee
    {
        private string Firstname;
        private string Lastname;
        private string DOB;
        private char Gender;
        private string SSN;
        private string Role;
        private decimal Salary;


        public Employee()
        {
        }

        public Employee(string Fname, string Lname, string DOB, char Gender, string SSN,string Role, decimal Salary)
        {
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.DOB = DOB;
            this.Gender = Gender;
            this.SSN = SSN;
            this.Role = Role;
            this.Salary = Salary;

        }

        public string GetFName()
        {
            return Firstname;
        }
        public void setFName(string Fname)
        {
            this.Firstname = Fname;
        }

        public string GetLName()
        {
            return this.Lastname;
        }
        public void setLName(string Lname)
        {
            this.Lastname = Lname;
        }
        public string GetDOB()
        {
            return this.DOB;
        }
        public void SetDOB(string birthDay)
        {
            this.DOB = birthDay;
        }

        public char GetGender()
        {
            return this.Gender;
        }

        public void setGender(char gender)
        {
            this.Gender = gender;
        }

        public string GetSSN()
        {
            return this.SSN;
        }

        public void SetSSN(string ssn)
        {
            this.SSN = ssn;
        }

        public void SetRole(string Role) 
        { 
            this.Role = Role; 
        }

        public string GetRole() 
        { 
            return Role; 
        }

        public void SetSalary(decimal Salary) 
        { 
            this.Salary = Salary; 
        }

        public decimal GetSalary() 
        { 
            return Salary; 
        }

        public Employee EmployeeRegistration(string SSN)
        {
            this.SetSSN(SSN);
            Console.WriteLine("First Name:");
            this.setFName(Console.ReadLine());
            Console.WriteLine("Last Name:");
            this.setLName(Console.ReadLine());
            Console.WriteLine("Date of birth:");
            this.SetDOB(Console.ReadLine());
            Console.WriteLine("Gender (M/F):");
            this.setGender(char.ToUpper(char.Parse(Console.ReadLine())));
            Console.WriteLine("Please enter your role with lowercase letters (manager,teacher,or executive):");
            this.SetRole(Console.ReadLine());
            Console.WriteLine("Salary:");
            this.SetSalary(decimal.Parse(Console.ReadLine()));

            return this;
        }
    }
}
