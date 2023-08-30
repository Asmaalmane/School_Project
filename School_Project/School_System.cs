using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    interface School_System
    {
        void Display();

        void SetFname(string Fname);
        string GetFname();

        void SetLname(string Lname);
        string GetLname();

        void SetSSN(string SSN);
        string GetSSN();

        void SetGender(char Gender);
        char GetGender();

        void SetDOB(string DOB);
        string GetDOB();
    }
}
