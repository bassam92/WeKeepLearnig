using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senumberRanges
{
    class Program
    {
        static void se(string[] args)
        {
            try
            {
                string[] inp;
                int[] inpn;
                Console.WriteLine("enter series pls:");
                string inpt = Console.ReadLine();
                inp = (inpt.Split(','));
                inpn = Array.ConvertAll(inp, int.Parse);
                int leng = inpn.Length;
                StringBuilder newOp = new StringBuilder();
                int i, j = 0;
                for (i = 0; leng > i; i++)
                {
                    if (newOp.Length == 0)
                    {
                        newOp.AppendLine(inpn[i].ToString());
                    }
                    if (i < leng - 1)
                    {
                        j = i + 1;
                    }
                    if (inpn[j] - inpn[i] == 1)
                    {
                        newOp.Append(",");
                        newOp.AppendLine(inpn[j].ToString());
                    }
                    else
                    {
                        if (newOp.ToString().Split(',').Length > 1)
                        {
                            string[] ar = newOp.ToString().Split(',');
                            Console.WriteLine(String.Format("{0}-{1}", Convert.ToInt32(ar[0]), Convert.ToInt32(ar[ar.Length - 1])));
                            newOp = new StringBuilder();
                        }
                        else
                        {
                            Console.WriteLine("\n" + newOp);
                            newOp = new StringBuilder();
                        }
                    }
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("unable to process your request"); ;
            }




        }
    }
}
