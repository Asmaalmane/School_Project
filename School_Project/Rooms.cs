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
        private Boolean occupied;
        private string roomType;
        private int SubjectID;

        public Rooms() { }

        public Rooms(int max_Capacity, int roomNo, bool occupied, string type, int subjectID)
        {
            Max_Capacity = max_Capacity;
            RoomNo = roomNo;
            this.occupied = occupied;
            Type = type;
            SubjectID = subjectID;
        }

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

        public Boolean Occupied
        {
            get { return this.occupied; }
            set { this.occupied = value; }
        }

        public string Type
        {
            get { return this.roomType; }
            set { this.roomType = value; }
        }

        public Rooms RoomsRegisteration()
        {
            Console.WriteLine("The Room number :");
            this.RoomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("How many students can learn in this room (the maximum capacity)?");
            this.MaxCap = int.Parse(Console.ReadLine());
            Console.WriteLine("Is it assigned to any course? (Yes/No)");
            string answer = Console.ReadLine();
            if (answer.Equals("Yes") || answer.Equals("yes") || answer.Equals("YES"))
            {
                this.Occupied = true;
            }
            else if (answer.Equals("no") || answer.Equals("No") || answer.Equals("NO"))
            {
                this.Occupied = false;
            }
            Console.WriteLine("What type of room is it: Class room, meeting room, or teacher lounge");
            this.Type=Console.ReadLine();

            this.SubjectID = -1;

            return this;
        }
    }
}
