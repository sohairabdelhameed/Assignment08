using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int CouuntOfHours { get; set; }

        public decimal HourRate { get; set; }


        public new void GetEmployeeType()
        {
            Console.WriteLine("Iam a PartTime Employee");
        }


        public override void GetEmployeeData()
        {
            Console.WriteLine($"PartTimeEmployee: Id: {Id} , Name : {Name} , Age : {Age} , Count of hours : {CouuntOfHours}, HourRate : {HourRate}");
        }

    }
}
