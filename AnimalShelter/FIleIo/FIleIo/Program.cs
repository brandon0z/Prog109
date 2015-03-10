using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIleIo
{
    class Program
    {
        private const String FILE_NAME = "c:/temp/list.txt";

        public void CallME()
        {
            StreamWriter writer = new StreamWriter(FILE_NAME, true); //true means its ok to append

            writer.Write("do homework");

            writer.Close();
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.CallME();
        }
    }
}
