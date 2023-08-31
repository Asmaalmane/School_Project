using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Executive : Employee
    {
        private string HeadOf;

        public Executive(string Fname, string Lname, string DOB, char Gender, string SSN, string Role, decimal Salary,string HeadOf) : base(Fname, Lname, DOB, Gender, SSN, Role, Salary)
        {
            this.HeadOf = HeadOf;
        }

        public Executive()
        {
        }

        public void SetHeadOf(string HeadOf)
        {
            this.HeadOf = HeadOf;
        }

        public string GetHeadOf()
        {
            return HeadOf;
        }

        public Executive ExecutiveRegistration(string SSN)
        {
            this.EmployeeRegistration(SSN);
            Console.WriteLine("Head of which department (School, High School, Mid School, Primary School, Kindergarten, or NA:");
            this.HeadOf=Console.ReadLine();

            return this;
        }

        public void Display()
        {
            Console.WriteLine("National ID:" + GetSSN());
            Console.WriteLine("Studnet Name:" + GetFName() + " " + GetLName());
            Console.WriteLine("Date of birth:" + GetDOB());
            Console.WriteLine("Gender (M/F):" + GetGender());
            Console.WriteLine("Role:" + GetRole());
            Console.WriteLine("Salary:" + GetSalary());
            if (GetRole().Equals("manager"))
            {
                Console.WriteLine("Head of:" +GetHeadOf());
            }
        }

    }
}

