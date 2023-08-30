using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Executive : Employee
    {
        private string HeadOf;

        public Executive()
        {
        }

        public Executive(string HeadOf)
        {
            this.HeadOf = HeadOf;
        }

        public void SetExecutive(string HeadOf)
        {
            this.HeadOf = HeadOf;
        }

        public string GetHeadOf()
        {
            return HeadOf;
        }

    }
}

