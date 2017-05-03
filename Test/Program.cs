using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass m = new MyClass();
            m.KeyValueDict = new Dictionary<string, string>();
            m.KeyValueDict.Add("1","a");
            m.KeyValueDict.Add("2","s");
            m.KeyValueDict.Add("3", "d");
            m.KeyValueDict.Add("4", "d");
            Console.WriteLine(m.KeyValueDict.First());
            Console.ReadKey();


        }
    }
    class MyClass
    {        public Dictionary<string, string> KeyValueDict { get; set; }
        
    }

}
