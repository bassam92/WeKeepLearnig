using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class DictionariesAndMaps
    {
         void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            string name = string.Empty;
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                phoneBook.Add(arr[0].ToString(), Int32.Parse(arr[1]));
            }
            while (true)
            {
                name = Console.ReadLine();
                if (phoneBook.TryGetValue(name, out number))
                    Console.WriteLine("{0}={1}", name, number);
                else
                    Console.WriteLine("Not found");
            }


            
            
        }
    }
}
