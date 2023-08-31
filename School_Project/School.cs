using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class School
    {
        private string School_name;
        private string School_location;
        private int num_of_students = 0;
        private int num_of_employees = 0;
        private int num_of_rooms = 0;

        public School() { }
        public School(string School_name, string School_location, int num_of_student, int num_of_employees, int num_of_rooms)
        {
            this.School_name = School_name;
            this.School_location = School_location;
            this.num_of_students=num_of_student;
            this.num_of_employees=num_of_employees;
            this.num_of_rooms=num_of_rooms;
        }

        public string SchoolName
        {
            get { return School_name; }
            set { School_name = value;}
        }

       public string SchoolLocation
        {
            get { return this.School_location; }
            set { School_location = value; }
        }

        public int Num_of_students
        {
            get { return this.num_of_students; }
            set { this.num_of_students=value; }
        }

        public int Num_of_employee
        {
            get { return this.num_of_employees; }
            set { this.num_of_employees = value; }
        }

        public int Num_of_rooms
        {
            get { return this.num_of_rooms; }
            set { this.num_of_rooms = value; }
        }

        public void Hire_employee()
        {
            this.Num_of_employee++;
        }
    }
}
