using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Teacher : Employee
    {
        private Course SubjectAssigned;

        public Teacher(string Fname, string Lname, string DOB, char Gender, string SSN, string Role, decimal Salary,Course SubjectAssigned):base(Fname,Lname,DOB,Gender,SSN,Role,Salary)
        {
            this.SubjectAssigned = SubjectAssigned;
        }

        public Teacher()
        {
        }

        public void SetSubjectAssigned(Course SubjectAssigned) 
        { 
            this.SubjectAssigned = SubjectAssigned; 
        }

        public Course GetSubjectAssigned() 
        { 
            return SubjectAssigned; 
        }

        public Teacher TeacherRegistration(string SSN, List<Course> courses)
        {
            Course Subject= new Course();

            this.EmployeeRegistration(SSN);
            Console.WriteLine("Enter the course ID are you assigned to?");
            int ID=int.Parse(Console.ReadLine());

            foreach (var c in courses)
            {
                if(ID== c.SID)
                {
                    Subject.SID = ID;
                    Subject.SName = c.SName;
                    break;
                }
            }
            
            this.SubjectAssigned = Subject;

            return this;
        }

        public Teacher AddSubjectToTeacher(Employee E,Course course)
        {
            this.setFName (E.GetFName());
            this.setLName (E.GetLName());
            this.SetDOB(E.GetDOB());
            this.SetSSN(E.GetSSN());
            this.SetRole(E.GetRole());
            this.setGender(E.GetGender());
            this.SetSalary(E.GetSalary());
            this.SetSubjectAssigned(course);

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
            Console.WriteLine("Subject Assigned:"+GetSubjectAssigned());
        }


    }
}

