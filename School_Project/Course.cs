using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Course
    {
        private int sID;
        public int SID
        {
            get
            {
                return this.sID;
            }
            set
            {
                this.sID = value;
            }
        }
        private string sName;
        public string SName
        {
            get
            {
                return this.sName;
            }
            set
            {
                this.sName = value;
            }
        }
    }
}
