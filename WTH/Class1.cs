using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTH
{
    public abstract class Math
    {
        // Abstract class can contain abstract member but has to be implemented in inhertited class
        public abstract void Add(int a, int b);

        public abstract int StepNo { get; set; }

        //non abstract member should have body 
        public void Sub(int a, int b)
        {
                    
        }
        
    }



    public interface iMath
    {
        int MyProperty { get; set; }
    }
    public class Geomentry
    {
        public virtual int  CalculateModulas(int a ,int b)
        {
            return a%b;
        }

        public void CalculateRaduis()
        {

        }
        
    }

    public class MyClass : Geomentry
    {
        MyClass m = new MyClass();

        
        public string Angle()
        {
            
            return "soe";
        }

        public int CalculateModulas(int a, int b)
        {
            a = a + 1;
            b = b + 1;

            return a;
        }
        
    }

    public class Calc : Math ,iMath
    {

        public override void Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override int StepNo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }        

        int iMath.MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
