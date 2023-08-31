using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class ClassRoom:Rooms
    {
        private string subjectassigned;

        public ClassRoom(string subjectassigned, int max_Capacity, int roomNo, bool accupied, string type) : base(max_Capacity, roomNo, accupied,type)
        {
            this.subjectassigned = subjectassigned;
        }

        public string SubjectAssigned 
        {
            get { return subjectassigned; }
            set { this.subjectassigned = value; }
        }
    }
}
