using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\C#\PracticeProject-2\PracticeProject-2\TextFile.txt";
            Console.WriteLine("Reading File using File.ReadAllText()");
            if (File.Exists(file))
            {
                {
                    string str = File.ReadAllText(file);
                    Console.WriteLine(str);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}