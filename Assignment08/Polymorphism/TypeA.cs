using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08.Polymorphism
{
    internal class TypeA
    {
        

        //Automatic prop
        //compiler will generate hidden private attribute [Backing Feild]
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        //object Member Functions [Non Static Functions]

        public void MyFunction1()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public void MyFunction02()
        {
            Console.WriteLine($"Type A : A = {A}");
        }

        //Applying Override keyword using "Override" Keyword

        

    }
}
