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
        public List<string> StudentCourses;
        //private int max_num_of_Subjects=5;

        public Student() { }
        public Student(string Fname, string Lname, string DOB, char Gender, string SSN,int level,List<string> StudentCourses)
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

        //public List<string> GetList() 
        //{
        //    return this.StudentCourses;
        //}

        //public void setList(List<string> STcourses)
        //{
        //    this.StudentCourses= STcourses;
        //}
        
    }

}
