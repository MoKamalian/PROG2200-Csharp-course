using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Teacher:Member, IPayee
    {
        public string Subject;

        //Declaring the existing method inside the interface IPayee
        public void Pay()
        {
            Console.WriteLine("Paying the teacher from Teacher Class");
        }

    }
}
