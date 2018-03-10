using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Feb_2018_Practica_07
{
    class UpperCaser : TextReader
    {
        StreamReader sr;
        public UpperCaser(StreamReader sr)  {
            this.sr = sr;
        }

        public override string ReadLine()
        {
            string line = sr.ReadLine();
            if (line != null) {
                line = line.ToUpper();
            }
            return line;
        }


        public void print() {
            String line;
            while ((line = ReadLine()) != null)
                Console.WriteLine(line);

            base.Close();
        }
    }
}
