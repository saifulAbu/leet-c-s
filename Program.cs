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
            MaximalSquare_221 m = new MaximalSquare_221();
            char[][] chars = new char[2][];
            chars[0] = new char[2];
            chars[1] = new char[2];
            m.MaximalSquare(chars);
        }

        /*
         static public void Main(String[] args)
        {  
            Console.WriteLine("hola, mundo!");
        }
         */
    }
}
