using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileRead
{
    class Program
    {

        private const String FILE_NAME = "c:/temp/list.txt";

        public void CallMe1()
        {
            StreamReader sr = new StreamReader(FILE_NAME);

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p2 = new Program();
            p2.CallMe1();
        }
    }
}
