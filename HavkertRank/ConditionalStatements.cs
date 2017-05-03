using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    /// <summary>
    /// Intro to Conditional Statements
    /// </summary>
    class ConditionalStatements
    {
        void Main()
        {            
                int N = Convert.ToInt32(Console.ReadLine());
                bool isWeird = false;
                ConditionalStatements program = new ConditionalStatements();
                isWeird = program.processN(N);
                if (isWeird)
                {
                    Console.WriteLine("Weird");
                }
                else
                    Console.WriteLine("Not Weird");
                
            
        }

        public bool processN(int N)
        {
            bool isWeird = false;
            if (N % 2 == 0)
            {
                isWeird = false;// N is Even
                if (6 <= N && N <= 20)
                {
                    isWeird = true;
                }
            }
            else
                isWeird = true;
            return isWeird;
        }
    }
}
