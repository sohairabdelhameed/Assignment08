using Assignment08.Binding;
using Assignment08.Polymorphism;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Assignment08
{
    internal class Program
    {
        #region Overloading

        //Method Overloadig
        //diffrentiate : by parameter 
        //Data type 

        //Method overloading Using just for readablity
        //public static int Sum(int X ,int Y) 
        //{
        //    return X + Y;

        //}
        //public static double Sum(double X, double Y)
        //{
        //    return X + Y ;

        //}
        //public static int Sum(int X, int Y,int Z)
        //{
        //    return X + Y + Z;

        //}
        //public static double Sum(double X, double Y, double Z)
        //{
        //    return X + Y + Z;

        //}

        //public static double Sum(int X, double Y)
        //{
        //    return X + Y;

        //}
        //public static double Sum(double X, int Y)
        //{
        //    return X + Y;

        //}

        #endregion

        #region MethodDataBindingEX01


        //public static void ProcessEmployee(FullTimeEmployee FullEmployee)
        //{
        //    if (FullEmployee == null)
        //    {
        //        FullEmployee.GetEmployeeType();
        //        FullEmployee.GetEmployeeData();
        //    }

        //}

        ////Not Overloading we didnot change the behavoir
        //public static void ProcessEmployee(PartTimeEmployee partTimeEmployee)
        //{
        //    if (partTimeEmployee == null)
        //    {
        //        partTimeEmployee.GetEmployeeType();
        //        partTimeEmployee.GetEmployeeData();
        //    }

        //}

        //Using DataBinding
        //Employee employee
        //can refer => Object Employee
        //Can Refer => Object from Class Inherit From Employee [FullTimeEmployee - PartTime Employee]
        public static void ProcessEmployee(Employee employee)
        {
            if (employee == null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region Polymorphism [Overloading]

            //int Result = Sum(1, 2);

            //Console.WriteLine($"Result = {Result}");


            //Result = Sum(1, 2,3);

            //Console.WriteLine($"Result = {Result}");

            // double  Result2 = Sum(1.2, 2.5);

            //Console.WriteLine($"Result = {Result2}");

            //Result2 = Sum(1.2, 3);

            #endregion

            #region Polymorphism [Overridding]
            ////Supported with class only
            ////Function Overriding Must be with the Relationship[Inheritance]

            //TypeA typeA = new TypeA(1);
            //typeA.A =  10;
            //typeA.MyFunction1();
            //typeA.MyFunction02();

            //Console.WriteLine("--------------------------------");
            //TypeB typeB = new TypeB(1,2);
            //typeA.A = 10;
            //typeB.A = 20;
            //typeB.MyFunction1();
            //typeB.MyFunction02();



            #endregion

            #region Binding Example01

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "sohair", 30, 6000);

            ProcessEmployee(fullTimeEmployee);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Id = 30,
                Name = "sohair",
                Age = 23,
                CouuntOfHours = 10,
                HourRate = 2.5M

            };

            ProcessEmployee(partTimeEmployee); //valid
        }

        //partTimeEmployee.Id = 30;
        //partTimeEmployee.Name = "sohair";
        //partTimeEmployee.Age = 23;
        //partTimeEmployee.CouuntOfHours = 10;
        //partTimeEmployee.HourRate = 2.5M;




    
        #endregion
    
    }
}
