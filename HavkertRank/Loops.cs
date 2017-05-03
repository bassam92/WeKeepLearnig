using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Loops
    {
         void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = i * n;
                Console.WriteLine("{0} x {1} = {2}",n,i,result);
            }

        }



    }
}
