using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTH
{
    class Program 
    {

         void Main(string[] args)
        {                        
            

            Vishnu objVP = new Vishnu();

            Console.WriteLine(" this is vishnus first mode {0}", objVP.mode);

            Console.WriteLine(" this is vishnus energy {0}", objVP.EnergyLevel());

            objVP.eat();

            Console.WriteLine(" this is vishnus energy {0}", objVP.EnergyLevel());

            objVP.eat();



            Console.ReadLine();


        }
    }


    public class Vishnu
    {
        public string mode="Started";
        
        public int strength ;

        public Vishnu()
        {
            strength = 0;
        }

        public void eat()
        {
            strength++;

            Console.WriteLine("she jus ate now");
        }

        public int EnergyLevel()
        {
            return strength;
        }

        public void Sleep()
        {
            mode = "sleep";
        }

        public void Wake()
        {
            mode = "awake";

        }
    }


    public class HumanActivity
    {
        public void Sleep()
        {

        }

        public void Wake()
        {

        }
    
    }

    public interface IhumanActivity
    {
        void Sleep();


        void Wake();

    }
}
