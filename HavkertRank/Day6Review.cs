using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day6Review
    {

         void Main()
        {
            
            int testStrcount = 0;
            testStrcount =  Convert.ToInt32(  (Console.ReadLine()));
            int strLength = 0;
            string segment1 = string.Empty;
            string segment2 = string.Empty;
            string[] sa = new string[testStrcount];
            for (int i = 0; i < testStrcount; i++)
            {                
                
                sa[i] = Console.ReadLine();                
                strLength = sa[i].Length;
                char[] chars = new char[strLength];
                chars = sa[i].ToArray();
                for (int j = 0; j < chars.Length;j++ )
                {
                    if (j == 0)
                        segment1 += chars[j].ToString();
                    else
                    {
                        if ((j % 2) == 0)
                        {
                            segment1 += chars[j].ToString();
                        }
                        else
                            segment2 += chars[j].ToString();
                    }

                }
                sa[i] = segment1 + " " + segment2;
                segment1 = segment2 = string.Empty;
            }
            for (int i = 0; i < sa.Length; i++)
            {
                Console.WriteLine(sa[i]);
                
            }
        }

    }
}
