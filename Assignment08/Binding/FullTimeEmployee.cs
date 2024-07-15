using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment08.Binding
{
    internal class FullTimeEmployee : Employee
    {
      

        public double  Salary { get; set; }

        public FullTimeEmployee(int id , string name , int age ,double salary):base(id, name, age) 
        {
            Salary = salary;

        }
        public new void GetEmployeeType()
        {
            Console.WriteLine("Iam a FullTimeEmployee");
        }


        public override void GetEmployeeData()
        {
            Console.WriteLine($"Employee: Id: {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}");
        }
    }


 

}
