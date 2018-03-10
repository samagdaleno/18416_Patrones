using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Feb_2018_Practica_07
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("text.txt");
            UpperCaser file = new UpperCaser(sr);
            file.print();

            Console.ReadLine();
        }
    }
}
