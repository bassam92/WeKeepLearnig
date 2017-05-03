using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHi
{
    class Program
    {
        static void Main(string[] args)
        {

            //DeerivedClass objDeerivedClass = new DeerivedClass();

            //int a = 5;
            //int b = a++;
            //int c = --a;
            //int d = a + 1;
            //Console.WriteLine("{0}{1}{2}{3}",a,b,c,d);
            //Console.ReadLine();




            //decimal totalCost;
            //decimal mealCost;
            //decimal tip;
            //decimal tax;
            //mealCost = decimal.Parse(Console.ReadLine());
            //tip = decimal.Parse(Console.ReadLine());
            //tax = decimal.Parse(Console.ReadLine());
            //totalCost = (mealCost + (tip / 100) + (tax / 100));
            //Console.WriteLine("The total meal cost is {0} dollars", totalCost);



            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int myInteger; decimal myDecimal; string myString;
            // Read and save an integer, double, and String to your variables.
            myInteger = Convert.ToInt32(Console.ReadLine());
            myDecimal = Decimal.Parse(Console.ReadLine());
            myString = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            myDecimal = decimal.Parse(d.ToString()) + decimal.Parse(myDecimal.ToString());
            
            myInteger = myInteger + i; myString = s + myString;
            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(myInteger);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myString);


            //try
            //{
            //    int w = int.Parse("s");
            //    Console.WriteLine(w);
                
            //    Console.ReadLine();
            //}            
            //catch (FormatException s)
            //{
            //    throw ;
            //}
            //catch (NullReferenceException s)
            //{
            //    throw s;
            //}


            //a objab = new b();
            //Console.ReadLine();           
            

            //baseClass bb = new baseClass();
            
            //baseClass bd  = new DerivedClass();

        }
    }


    class a
    {
        public a()
        {
            Console.WriteLine("a contructor no para");

        }

        public void method()
        {
            Console.WriteLine("base class: m1");
        }

    }

    class b : a
    {

        public b()
        {
            Console.WriteLine("b constructor no para");
        }

        //public b(int v) 
        //{
        //    Console.WriteLine("b constructor");
        //}

        public void method2()
        {
            Console.WriteLine("derived class: m1");
        }


    }

    class baseClass
    {
        private int Add(int a, int b) { return a + b; }
        private int Sub(int a, int b) { return a - b; }
        
    }

    class DerivedClass:baseClass
    {
        public int Multiply(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
        
    }


    #region factory pattern


    interface Imath
    {
          int add();

          int sub();

          int multiple();

    }

    class Math : Imath
    {

        public int add()
        {
            return 1;
        }

        public int sub()
        {
            return 1;
        }

        public int multiple()
        {
            return 1;
        }
    }


    class Ma :Imath
    {
        public int add()
        {
            return 2;
        }

        public int sub()
        {
            return 2;
        }

        public int multiple()
        {
            return 3;
        }
        
    }

    #endregion
    
}

