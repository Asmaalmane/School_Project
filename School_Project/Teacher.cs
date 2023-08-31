using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Teacher : Employee
    {
        private String SubjectAssigned;

        public Teacher(string Fname, string Lname, string DOB, char Gender, string SSN, string Role, decimal Salary,String SubjectAssigned):base(Fname,Lname,DOB,Gender,SSN,Role,Salary)
        {
            this.SubjectAssigned = SubjectAssigned;
        }

        public void SetSubjectAssigned(string SubjectAssigned) 
        { 
            this.SubjectAssigned = SubjectAssigned; 
        }

        public string GetSubjectAssigned() 
        { 
            return SubjectAssigned; 
        }

        public void Display()
        {
            Console.WriteLine("National ID:" + GetSSN());
            Console.WriteLine("Studnet Name:" + GetFName() + " " + GetLName());
            Console.WriteLine("Date of birth:" + GetDOB());
            Console.WriteLine("Gender (M/F):" + GetGender());
            Console.WriteLine("Role:" + GetRole());
            Console.WriteLine("Salary:" + GetSalary());
            Console.WriteLine("Subject Assigned:"+GetSubjectAssigned());
        }


    }
}

