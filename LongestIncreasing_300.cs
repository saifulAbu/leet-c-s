using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class LongestIncreasing_300
    {
        public int LengthOfLIS(int[] nums)
        {
            int N = nums.Length;
            int[] dp = new int[N];

            dp[0] = 1;


            for (int i = 1; i < N; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                        }
                    }
                }
            }

            int max = 1;

            for (int i = 1; i < N; i++)
            {
                if (dp[i] > max)
                {
                    max = dp[i];
                }
            }

            return max;
        }
    }
}
