using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class CountDigit_2520
    {
        public int CountDigits(int num)
        {
            int orig = num;
            int res = 0;
            while (num != 0) {
                int curDigit = num % 10;
                num /= 10;
                if (orig % curDigit == 0)
                {
                    res++;
                }
            } 
            return res;
        }
    }
}
