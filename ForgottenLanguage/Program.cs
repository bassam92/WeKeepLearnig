using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgottenLanguage
{
    //    class Program : dataHouse
    //    {

    //        static void Main(string[] args)
    //        {
    //            dataHouse dh = new dataHouse();
    //            dh.temp = Console.ReadLine();
    //            dh.noOfTest = int.Parse(dh.temp);

    //            dh.temp = Console.ReadLine();
    //            dh.noOfForgottenWord = int.Parse(dh.temp.Split(' ')[0]);
    //            dh.noOfModernPhrase = int.Parse(dh.temp.Split(' ')[1]);



    //        }
    //    }
    //    class dataHouse : valueHouse
    //    {
    //        public int noOfTest = 0;
    //        public int noOfForgottenWord = 0;
    //        public int noOfModernPhrase = 0;
    //        public string temp = string.Empty;

    //        public bool doesExist()
    //        {
    //            bool result = false;
    //            return result;
    //        }
    //    }

    //    class valueHouse
    //    {
    //        public string fWord = string.Empty;
    //        public string mPhrase = string.Empty;
    //    }

    //    class A:AClass
    //    {
    //        void anotherMethod()
    //        {


    //        }
    //    }

    //    public abstract class AClass
    //    {
    //       public  void Mymethod() {           
    //        }
    //    }










    class Program
    {

        static void Main(string[] args)
        {

            Vishnu objVP = new Vishnu();
            Console.WriteLine(" this is vishnus first mode {0}", objVP.mode);
            Console.WriteLine(" this is vishnus energy {0}", objVP.EnergyLevel());
            objVP.eat();
            objVP.mode = objVP.Sleep();
            Console.WriteLine(" this is vishnus is mode {0}", objVP.mode);
            objVP.mode = objVP.Wake();
            Bassam objBS = new Bassam();
            objBS.mode = objBS.Sleep();
            Console.WriteLine(" this is bassam is mode {0}", objBS.mode);
            Console.WriteLine(" this is vishnus is mode {0}", objVP.mode);
            Console.ReadLine();


            ArrayList list= new ArrayList();
            list.Add(objBS);

            foreach (Bassam s in list)
            {
                Console.WriteLine(s.strength); 
            }


            List<int> ss = new List<int>();
            ss.Add(2);
            ss.Add(2);
            ss.Add(2);
            ss.Add(2);

            


            string value1 = @"C:\perls\word.txt";
            string value2 = @"C:\file.excel.dots.xlsx";

            // ... Get extensions.
            string ext1 = Path.GetExtension(value1);
            string ext2 = Path.GetExtension(value2);
            Console.WriteLine(ext1);
            Console.WriteLine(ext2);
            
            
            Console.ReadLine();





        }
    }


    public class Vishnu
    {
        public string mode = "Started";

        public int strength;

        public Vishnu()
        {
            strength = 0;
        }

        public void eat()
        {
            strength++;

            Console.WriteLine("she jus ate now");
        }

        public void Play()
        {
            eat();

            mode = "Playing";
        }


        public int EnergyLevel()
        {
            return strength;
        }



        public string Sleep()
        {
            return "deep sleep";
        }

        public string Wake()
        {
            return "charm awake";
        }
    }


    public class Bassam
    {
        public string mode = "Started";

        public int strength;

        public Bassam()
        {
            strength = 0;
        }

        public void eat()
        {
            strength++;

            Console.WriteLine("she jus ate now");
        }

        public void Play()
        {
            eat();
            eat();

            mode = "Playing";
        }

        public int EnergyLevel()
        {
            return strength;
        }



        public string Sleep()
        {
            return "sleep";
        }

        public string Wake()
        {
            return "awake";
        }
    }


    public class HumanActivity
    {
        public string Sleep()
        {
            return "sleep";
        }

        public string Wake()
        {
            return "awake";
        }

    }



    //public abstract class IhumanActivity1
    //{


    //    string Sleep();


    //    string Wake();
    //}

    //public interface IhumanActivity
    //{
    //    string Sleep();


    //    string Wake();
    //}







}
