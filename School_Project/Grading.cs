using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Grading
    {
        private int examGrade = 0;
        private double attendPercentag = 0;
        public int ExamGrade
        {
            get
            {
                return this.examGrade;
            }
            set
            {
                this.examGrade = value;
            }
        }
        public double AttendPercentag
        {
            get
            {
                return this.attendPercentag;
            }
            set
            {
                this.attendPercentag = value;
            }
        }
    }
}
