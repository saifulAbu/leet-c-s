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
            MinDifficulty_1335 m = new MinDifficulty_1335();
            int[] jobDiff = { 6, 5, 7, 3, 2, 1};
            m.MinDifficulty(jobDiff, 2);
        }

        /*
         static public void Main(String[] args)
        {  
            Console.WriteLine("hola, mundo!");
        }
         */
    }
}
