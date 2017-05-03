using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char c = 'Y';
                while (c == 'Y' || c == 'y')
                {
                    Console.WriteLine("Enter series length..");
                    string str = Console.ReadLine();
                    string[] strSeries = str.Split(',');
                    int[] intSeries = new int[strSeries.Length];
                    if (intSeries.Length > 0)
                    {
                        for (int j = 0; j < strSeries.Length; j++)
                        {
                            intSeries[j] =Convert.ToInt16(strSeries[j]);
                        }
                        int[] intSet = new int[intSeries.Length];
                        int intCount = -1;
                        for (int k = 0; k < intSeries.Length; k++)
                        {
                            intCount += 1;
                            intSet[intCount] = intSeries[k];
                            if (intCount > 0)
                            {
                                int intDifference = intSet[intCount] - intSet[intCount - 1];
                                if (intDifference > 1)
                                {
                                    if (intCount == 1)
                                    {
                                        Console.WriteLine(string.Format("{0}", intSet[0]));
                                    }
                                    else
                                    {
                                        Console.WriteLine(string.Format("{0}-{1}", intSet[0], intSet[intCount - 1]));
                                    }
                                    intCount = 0;
                                    intSet = new int[intSeries.Length];
                                    intSet[0] = intSeries[k];
                                }
                            }
                        }
                        if (intCount == 0)
                        {
                            Console.WriteLine(string.Format("{0}", intSet[0]));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0}-{1}", intSet[0], intSet[intCount]));
                        }
                    }
                    Console.WriteLine("Do you want to try again, press y.");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine("-------------------------------------------------");
                }
                Console.ReadKey();
            }
            
            catch(Exception ex)
            { 

            }
        }
    }
}


 //char c = 'Y';
 //               while (c == 'Y' || c == 'y')
 //               {
 //                   Console.WriteLine("Enter series length..");
 //                   string str = Console.ReadLine();
 //                   string[] strSeries = str.Split(',');


 //                   int intLength = int.Parse(Console.ReadLine());
 //                   int[] intSeries = new int[intLength];
 //                   if (intLength > 0)
 //                   {
 //                       for (int j = 0; j < intLength; j++)
 //                       {
 //                           intSeries[j] = int.Parse(Console.ReadLine());
 //                       }
 //                       int[] intSet = new int[intLength];
 //                       int intCount = -1;
 //                       for (int k = 0; k < intSeries.Length; k++)
 //                       {
 //                           intCount += 1;
 //                           intSet[intCount] = intSeries[k];
 //                           if (intCount > 0)
 //                           {
 //                               int intDifference = intSet[intCount] - intSet[intCount - 1];
 //                               if (intDifference > 1)
 //                               {
 //                                   if (intCount == 1)
 //                                   {
 //                                       Console.WriteLine(string.Format("{0}", intSet[0]));
 //                                   }
 //                                   else
 //                                   {
 //                                       Console.WriteLine(string.Format("{0}-{1}", intSet[0], intSet[intCount - 1]));
 //                                   }
 //                                   intCount = 0;
 //                                   intSet = new int[intLength];
 //                                   intSet[0] = intSeries[k];
 //                               }
 //                           }
 //                       }
 //                       if (intCount == 0)
 //                       {
 //                           Console.WriteLine(string.Format("{0}", intSet[0]));
 //                       }
 //                       else
 //                       {
 //                           Console.WriteLine(string.Format("{0}-{1}", intSet[0], intSet[intCount]));
 //                       }
 //                   }
 //                   Console.WriteLine("Do you want to try again, press y.");
 //                   c = Console.ReadKey().KeyChar;
 //                   Console.WriteLine("-------------------------------------------------");
 //               }
 //               Console.ReadKey();