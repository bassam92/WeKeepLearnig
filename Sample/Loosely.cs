using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Loosely
    {
        void Main(string[] args)
        {
            IDatabase db = new Database();
            db.add("bassam");

        }

    }

    interface IDatabase
    {
        void add(string name);
    }

    public class Database : IDatabase
    {


        public void add(string name)
        {
            Console.WriteLine("{0} name added ", name);
        }

        //public void remove(string name){
        //    Console.WriteLine("{0} removed",name);
        //}

    }

    public class anotherClass
    {

        Database objDB = new Database();
    }

 
}
