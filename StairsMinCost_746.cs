using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class StairsMinCost_746
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int[] dp= new int[cost.Length];
            dp[0]= cost[0];
            dp[1]= cost[1];

            for (int i = 2; i < cost.Length; i++) {
                dp[i]= cost[i] + Math.Min(dp[i-1], dp[i-2]);
            }

            return Math.Min(dp[dp.Length - 1], dp[dp.Length - 2]);
        }
    }
}
