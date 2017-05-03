using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTH
{
    class inter:sathish,bassam
    {
        static void main() { 
        
        
        }
         void bassam.m1()
        {
            throw new NotImplementedException();
        }

            public void m1()
          {
              throw new NotImplementedException();
          }

        bassam b = new inter();
        sathish s = new inter();

        void ba()
        {
            b.m1();
            s.m1();
        }
      
    }

    


    interface bassam
    {
        void m1();
    }
    interface sathish
    {
        void m1();
        
    }
}
