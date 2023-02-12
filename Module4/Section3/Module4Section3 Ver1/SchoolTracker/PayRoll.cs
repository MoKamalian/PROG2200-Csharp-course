using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    internal class PayRoll
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal = new Principal();

        public void PayAll()
        {
            teacher1.Pay();
            teacher2.Pay();
            principal.Pay();

        }

    }
}
