using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class Program
    {

        static public void Main(String[] args)
        {
            List<string> words = new List<string> {"as", "asas"};
            string str = "asast";
            WordBreak_139 wb = new WordBreak_139();
            bool res = wb.WordBreak(str, words);

            Console.WriteLine("result : " + res);
        }

        /*
         static public void Main(String[] args)
        {  
            Console.WriteLine("hola, mundo!");
        }
         */
    }
}
