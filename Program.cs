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
            int[] nums = { 1, 1, 0, 1, 1, 1, 0 };
            _485_max_conseq prob = new _485_max_conseq();
            Console.WriteLine(prob.FindMaxConsecutiveOnes(nums));
        }

        /*
         static public void Main(String[] args)
        {  
            Console.WriteLine("hola, mundo!");
        }
         */
    }
}
