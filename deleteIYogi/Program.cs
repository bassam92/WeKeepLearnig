using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleteIYogi
{
    class Program
    {

        public static string currentPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
        
        public delegate int AddDelegate(int a, int b);

        public static void someother()
        {
            //foreach (string path in args)
            //{

            AddDelegate objAdd = new AddDelegate(AddIntegers);

           int result = refDelegate(objAdd);





            string path = "D:";
            if (File.Exists(path))
            {
                // This path is a file
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory

                string fileName = "Log.txt";
                string filePath = currentPath + fileName;
                File.Open(filePath, FileMode.OpenOrCreate).Close();

                File.WriteAllText(filePath, "############Log File############ /n Created" + DateTime.Now + "s");

                ProcessDirectory(path);

            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }
            //}
        }

        public static void AddNumber(int add1)
        {

        }

        public static int AddIntegers(int add1, int add2)
        {
            return add1 + add2;
        }

        public static int refDelegate(AddDelegate addRef)
        {
            return addRef(5, 6);
        }


        private static void createFile(string fileName)
        {
            File.Create(currentPath + fileName);

        }


        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                if (subdirectory.Contains("New folder"))
                    DeleteFolder(subdirectory);


        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Log.txt";
            File.Exists((currentPath + "/" + fileName));
        }

        public static void DeleteFolder(string path)
        {
            Directory.Delete(path, true);
        }
    }
}
