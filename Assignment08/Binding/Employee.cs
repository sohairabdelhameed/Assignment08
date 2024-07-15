using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08.Binding
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void GetEmployeeType()
        {
            Console.WriteLine("Iam Employee");
        }

        //virtual => can override using override keyword
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Employee: Id: {Id} , Name : {Name} , Age : {Age}");
        }



    }
}
