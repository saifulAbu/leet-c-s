using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class MaxScore_1770
    {
        int[] nums, multipliers;
        Dictionary<int, int> dp = new Dictionary<int, int>();
        int N;

        public int MaximumScore(int[] nums, int[] multipliers)
        {
            this.nums = nums;
            this.multipliers = multipliers;
            this.N = nums.Length;
            return soln(0, nums.Length - 1);
        }

        public int soln(int i, int j) {
            int m = N + i - j - 1;
            if (m == multipliers.Length)
            {
                return 0;
            }
            else {
                int key = i * N + j;
                if (!dp.ContainsKey(key))
                {
                    dp[key] = Math.Max(
                                nums[i] * multipliers[m] + soln(i + 1, j),
                                nums[j] * multipliers[m] + soln(i, j - 1)
                    );
                } 
                return dp[key];
            }
        }
    }
}
