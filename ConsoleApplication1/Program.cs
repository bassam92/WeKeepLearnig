using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime at = new DateTime();

            DateTime edd = new DateTime();
            DateTime eddwrong = new DateTime();

            at = DateTime.Now;
            edd = Convert.ToDateTime("12/01/2017 00:00");
            try
            {
                eddwrong = Convert.ToDateTime("11/01/2017 18:30");
                eddwrong = eddwrong.ToLocalTime();
            }
            catch (Exception e)
            {
                throw e;
            }
            string sGestAge = string.Empty;

            int nTotalDays = 280 - (eddwrong.Subtract(DateTime.Now).Days);
            int nGestWeeks = nTotalDays / 7; //542780 538859 542596
            int nGestDays = nTotalDays % 7;
            sGestAge = nGestWeeks.ToString() + "WEEKS" + nGestDays + "DAYS";

          
             int    nTotalDays1 = 280 - (edd.Subtract(at).Days);
               

        }

        


    }
}
