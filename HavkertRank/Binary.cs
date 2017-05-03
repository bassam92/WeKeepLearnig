using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Binary
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string r = string.Empty;
            r = toBinary(n, r);
            r = new string(r.Reverse().ToArray());
            Console.WriteLine(count1s(r)); ;
            //Console.ReadLine();
        }

        public static string toBinary(int n, string r)
        {
            if (n == 0)
                return r;
            r += n % 2;
            n = n / 2;
            return (toBinary(n, r));
        }
        public static int count1s(string i)
        {
            i.ToArray();
            int count = 0;
            char[] ch = i.ToArray();
            for (int y = 0; y < ch.Length; y++)
            {
                if (ch[y] == 49)
                {
                    ++count;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }


    }
}
