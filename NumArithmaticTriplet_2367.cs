using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class NumArithmaticTriplet_2367
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            HashSet<int> numSet = new HashSet<int>();
            foreach (var num in nums) { 
               numSet.Add(num);
            }

            int res = 0;
            foreach (var num in nums)
            {
                if(numSet.Contains(num-diff) && numSet.Contains(num + diff)) {
                    res++;
                }
            }

            return res;
        }
    }
}
