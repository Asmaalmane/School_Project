using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Course
    {
        private int SubjectID;
        private string SubjectName;
        private string teacherSSN;

        public Course() { }
        public int SID
        {
            get
            {
                return this.SubjectID;
            }
            set
            {
                this.SubjectID = value;
            }
        }
        public string SName
        {
            get
            {
                return this.SubjectName;
            }
            set
            {
                this.SubjectName = value;
            }
        }
        public string TeacherSSN
        {
            get
            {
                return this.teacherSSN;
            }
            set
            {
                this.teacherSSN = value;
            }
        }
    }
}
