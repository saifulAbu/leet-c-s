using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _1295_find_even_digits
    {
        public int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach (int num in nums) { 
                if (NumDigits(num) % 2 == 0) { 
                    count++;
                }
            }
            return count;
        }
        private int NumDigits(int num)
        {
            return (int)Math.Floor(Math.Log10(num)) + 1;
        }

    }
}
