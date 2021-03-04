using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StudentRecords
{
    class Record
    {
        public static void Do()
        {
            ReadLine();
        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\RecordsOfStudent.txt";
            Console.WriteLine(filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("\nFile exists\n");
                string[] contents = File.ReadAllLines(filename);

                int len = contents.Length;
                for (int i = 0; i < len - 1; i++)
                {
                    string[] data = contents[i].Split(", ");
                    Console.WriteLine("Name: "+data[0] + ", " + "Dept: "+data[1]);
                }
                Console.WriteLine("\nEnter name to be searched:");
                string ele = Console.ReadLine();
                SearchElement(ele, contents);
                Console.WriteLine("\nSorting according the department names:");
                SortFile(contents);
            }



        }

        private static void SearchElement(string element, string[] contents)
        {
            int len = contents.Length;
            bool flag = false;
            int ind = 0;
            for (int i = 0; i < len - 1; i++)
            {
                string[] data = contents[i].Split(", ");
                if (data[0].Equals(element))
                {
                    flag = true;
                    ind = i;
                }
               
            }
            if (flag)
            {
                Console.WriteLine("Name found at index:{0}", ind);
            }
            else
            {
                Console.WriteLine("Name not found");
            }
        }

        private static void SortFile(string[] contents)
        {
            int len = contents.Length;
            var info = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < len - 1; i++)
            {
                string[] data = contents[i].Split(", ");
                info.Add(new KeyValuePair<string, string>(data[0], data[1]));
            }
            /*Console.WriteLine("\nUnsorted list");
            foreach (var val in info)
            {
                Console.WriteLine(val);
            }*/
            info.Sort((x, y) => (x.Value.CompareTo(y.Value)));
            foreach (var val in info)
            {
                Console.Write("Name: "+val.Key+", ");
                Console.WriteLine("Dept: "+val.Value);
            }
        }
    }
}
