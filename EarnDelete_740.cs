using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class EarnDelete_740
    {
        public int DeleteAndEarn(int[] nums)
        {
            int maxNum = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                counts[num] = getVal(counts, num) + num;
                //Console.WriteLine(num);
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            if (counts.Count() <= 1)
            {
                return counts[maxNum];
            }

            int[] dp = new int[maxNum + 1];
            //Console.WriteLine(maxNum);
            dp[0] = 0;
            dp[1] = getVal(counts, 1);

            for (var i = 2; i <= maxNum; i++)
            {
                //dp[i] = getVal(counts, i) + dp[i-2];
                dp[i] = Math.Max(getVal(counts, i) + dp[i - 2], dp[i - 1]);
            }

            foreach (var val in dp)
            {
                Console.Write("*" + val);
            }

            return Math.Max(dp[dp.Length - 1], dp[dp.Length - 2]);
            //return 0;
        }

        private int getVal(Dictionary<int, int> counts, int key)
        {
            if (counts.ContainsKey(key))
            {
                return counts[key];
            }
            return 0;
        }
    }
