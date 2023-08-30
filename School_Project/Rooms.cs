using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Rooms
    {
        private int Max_Capacity;
        private int RoomNo;
        private Boolean Accupied;
        public int MaxCap
        {
            get { return this.Max_Capacity; }
            set { this.Max_Capacity = value; }

        }
        
        public int RoomNumber
        {
            get { return this.RoomNo ; }
            set { this.RoomNo = value; }
        }

        public Boolean accaup
        {
            get { return this.Accupied; }
            set { this.Accupied = value; }
        }
    }
}
