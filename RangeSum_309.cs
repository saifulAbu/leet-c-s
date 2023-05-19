using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class RangeSum_309
    {
        int[] rangeSum;
        public RangeSum_309(int[] nums)
        {
            rangeSum = new int[nums.Length];
            rangeSum[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                rangeSum[i] = nums[i] + rangeSum[i-1];
            }
        }

        public int SumRange(int left, int right)
        {

        }
    }
}
