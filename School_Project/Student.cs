using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School_Project
{
    internal class Student
    {
        private string Firstname;
        private string Lastname;
        private string DOB;
        private char Gender;
        private string SSN;
        private int level;
        public List<Course> StudentCourses;
        //private int max_num_of_Subjects=5;

        public Student() { }
        public Student(string Fname, string Lname, string DOB, char Gender, string SSN,int level,List<Course> StudentCourses)
        {
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.DOB = DOB;
            this.Gender = Gender;
            this.SSN = SSN;
            this.level = level;
            this.StudentCourses = StudentCourses;
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
            this.Lastname= Lname;
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

        public int GetLevel()
        {
            return level;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public string GetSSN()
        {
            return this.SSN;
        }

        public void SetSSN(string ssn)
        {
            this.SSN = ssn;
        }

        public Student StudentRegistration(string SSN)
        {
            this.SSN= SSN;
            Console.WriteLine("Please enter the following data:");
            Console.WriteLine("FirstName:");
            this.Firstname=Console.ReadLine();
            Console.WriteLine("LastName:");
            this.Lastname=Console.ReadLine();
            Console.WriteLine("Date of birth:");
            this.DOB=Console.ReadLine();
            Console.WriteLine("Level:");
            this.level=int.Parse(Console.ReadLine());
            Console.WriteLine("Gender (M/F):");
            this.Gender = char.ToUpper(char.Parse(Console.ReadLine()));

            this.StudentCourses = new List<Course>();
            return this;
        }

        public void Display()
        {
            Console.WriteLine("National ID:" + GetSSN());
            Console.WriteLine("Studnet Name:" + GetFName() + " " + GetLName());
            Console.WriteLine("Date of birth:" + GetDOB());
            Console.WriteLine("Gender (M/F):" + GetGender());
            Console.WriteLine("Level:" + GetLevel());
            Console.WriteLine("Courses assigned:");
            if (StudentCourses.Count > 0)
            {
                for (int j = 0; j < StudentCourses.Count; j++)
                {
                    Console.WriteLine("Course ID:" + StudentCourses[j].SID + " is " + StudentCourses[j].SName);
                }
            }
            else
            {
                Console.WriteLine("No courses are assigned under this name yet");
            }
        }
        
    }

}
