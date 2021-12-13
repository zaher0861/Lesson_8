using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/bagae/OneDrive/Документы/Study/Study";
            string[] directory = Directory.GetDirectories(path);
            Console.WriteLine("В корневой папке {0} находятся:", path);
            Console.WriteLine();
            int i = 1;
            foreach (string d in directory)
            {
                Console.WriteLine("{0}. {1}, а в ней находятся:", i, d);
                string[] directory1 = Directory.GetDirectories(d);
                foreach (string d1 in directory1)
                {
                    Console.WriteLine("   {0}", d1);
                }
                i++;
                Console.WriteLine();
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
