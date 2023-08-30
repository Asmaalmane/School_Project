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


        public Teacher() { }

        public Teacher(String SubjectAssigned)
        {
            this.SubjectAssigned = SubjectAssigned;

        }

        public void SetSubjectAssigned(string SubjectAssigned) { this.SubjectAssigned = SubjectAssigned; }

        public string GetSubjectAssigned() { return SubjectAssigned; }



    }
}

