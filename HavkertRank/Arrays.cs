using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Arrays
    {
        void Main()
        {
            int arraySize = 0;
            arraySize = Convert.ToInt32(Console.ReadLine());
            string[] toReverse = new string[(arraySize * 2)];
            string[] Reversed = new string[(arraySize * 2)];
            toReverse = Console.ReadLine().Split(' ');
            int[] inte = Array.ConvertAll(toReverse, int.Parse);
            int b = inte.Length - 1;

            for (int a = 0; a < toReverse.Length; a++)
            {
                Reversed[b] = toReverse[a];
                b--;
            }
            string op = string.Join(" ", Reversed);
            Console.WriteLine(op);

            Console.ReadKey();           

        }
    }
}
