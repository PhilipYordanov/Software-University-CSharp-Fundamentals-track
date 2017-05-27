using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String fn;
            String myOutPut;

            fn =Convert.ToString(Console.ReadLine());
            string path = @"file.txt";

            myOutPut = fn;

            if (!File.Exists(path))
            {
                StreamWriter sw = new StreamWriter(new FileStream("../../file.txt", FileMode.Create));
                Console.SetOut(sw);  //пренасочва към sw

                //програма

                sw.Close();     //и това в края
            }
        }
    }
}
