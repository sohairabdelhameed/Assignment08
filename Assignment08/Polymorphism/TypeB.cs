using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08.Polymorphism
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a , int b):base(a)
        {
            B = b;
        }

        //Overriding 
        //1. Using New Keyword
        //2. Using Override keyword

        //Applying Override keyword using "New" Keyword

        public new void MyFunction01() // new vwesion 
        {
            Console.WriteLine("I am derived [Child]");
        }

        //public override void MyFunction02()
        //{
        //    Console.WriteLine($"Type A : A = {A}");

        //}
    }
}
