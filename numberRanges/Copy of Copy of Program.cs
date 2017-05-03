using System;
using System.Text;

namespace palindromSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome();
        }

        private static void CheckPalindrome()
        {
            //ip the test case then 
            int testCase = 0;
            testCase = int.Parse(Console.ReadLine());
            StringBuilder Oresult = new StringBuilder();
            
          
                bool result = false;
                for (int j = 0; j < testCase; j++)
                {
                    string a, b;
                    a = Console.ReadLine();
                    b = Console.ReadLine();
                    foreach (Char c in a)
                    {
                        if (b.Contains(c.ToString()))
                        {
                            result = true;
                        }
                        if (result == true)
                            break;
                    }
                        Console.WriteLine(result == true? "Yes":"No");
                    //if (result == true)
                    //    Oresult.AppendLine("Yes");
                    //else
                    //    Oresult.AppendLine("No");
                }
                
                Oresult = new StringBuilder();
           
                Console.Read(); 
 
        }
    }
}