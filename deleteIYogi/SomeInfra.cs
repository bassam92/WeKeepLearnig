using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleteIYogi
{
    class SomeInfra
    {
        public delegate void MyDelegate(int a, int b);

        static int a;
        static int b;

        static void fn_ToHookToTheDelegate(int val1, int val2)
        {
            a = val1 * val2;
        }

        static void Main(string[] args)
        {
            //Creating the Delegate Instance
            MyDelegate delObj = new MyDelegate(fn_ToHookToTheDelegate);
            
            Console.Write("Please Enter Values");
            int v1 = Int32.Parse(Console.ReadLine());
            int v2 = Int32.Parse(Console.ReadLine());
            //Call delegate for processing
            delObj(v1, v2);


            Console.WriteLine("Multiplication : " + a);

            delObj = new MyDelegate(fn_another);

            delObj(v1, v2);

            Console.WriteLine("Addition: " + b);
            Console.ReadLine();
        }

        private static void fn_another(int a1, int b2)
        {
            b= a1 + b2;
        }


    }
}
