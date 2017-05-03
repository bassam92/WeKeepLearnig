using System;
using System.Text;

namespace numberRanges
{
    class Program12
    {
        static void Main1(string[] args)
        {

            //NumberRange();

            CheckPalindrome();

        }

        private static void CheckPalindrome()
        {
            //ip the test case then 
            int testCase = 0;
            testCase = int.Parse(Console.ReadLine());
            StringBuilder Oresult = new StringBuilder();

            for (int j = 0; j < testCase; j++)
            {
                string a, b;
                a = Console.ReadLine();
                b = Console.ReadLine();
                bool result = false;
                foreach (Char c in a)
                {
                    if (b.Contains(c.ToString()))
                    { result = true; break; }
                }
                Console.WriteLine(result == true ? Oresult.AppendLine("Yes") : Oresult.AppendLine("No"));
                //if (IsPalin(a) || IsPalin(b) || concatenateAndCheck(a, b))
                //{
                //    result = true;
                //}
                if (result == true)
                    Oresult.AppendLine("Yes");
                else
                    Oresult.AppendLine("No");

            }
            //    Console.WriteLine("enter the first string");
            
            //Console.WriteLine("enter the second string");


            Console.WriteLine(Oresult);
            Console.Read();
            
        }

        private static bool concatenateAndCheck(string a, string b)
        {
            bool conc = false;
            for (int i = 0; i < b.Length; i++)
            {
                a += b[i].ToString();
                conc = IsPalin(a);
                if (conc == true)
                    return conc;
            }
            return conc;
        }

        private static bool IsPalin(string a)
        {
            string revs = string.Empty;
            for (int i = a.Length - 1; i >= 0; i--) //String Reverse
            {
                revs += a[i].ToString();
            }
            if (revs == a)
                return true;
            else
                return false;
        }

        private static void NumberRange()
        {
            string[] inp;
            int[] inpn;
            string again = "y";
            while (again == "y" || again == "Y")
            {
                Console.WriteLine("enter series pls:");
                string inpt = Console.ReadLine();
                inp = (inpt.Split(','));
                inpn = Array.ConvertAll(inp, int.Parse);
                int leng = inpn.Length;
                StringBuilder newOp = new StringBuilder();
                int i, j = 1, one = 0, lastValue = 0;
                char mode = 'd'; string outp = "";
                newOp.Append(inpn[0].ToString());
                for (i = 0; leng > i; i++)
                {
                    if (leng > j)
                        j = i + 1;
                    if (leng > j)
                        one = inpn[j] - inpn[i];
                    if (one == 1)
                    {
                        mode = 'c';
                        lastValue = inpn[i];
                        if (leng == j)
                            newOp.Append(" - " + lastValue.ToString());
                    }
                    else
                    {
                        newOp.AppendLine(" - " + inpn[i].ToString());
                        if (leng != j)
                        {
                            newOp.Append(inpn[j].ToString());

                        }
                    }
                    outp = newOp.ToString();
                }
                Console.WriteLine(outp);
                Console.ReadLine();
                Console.WriteLine("Do you wanna continue again (y/n) ?");
                again = Console.ReadLine();

            }
        }
    }
}
