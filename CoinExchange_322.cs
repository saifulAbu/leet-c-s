using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class CoinExchange_322
    {
        int INFINITY = 10_001;
        int MIN_COIN = 0;
        int NUM_COINS = 0;
        int [] dp;
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0) { return 0; }
            
            NUM_COINS= coins.Length;
            MIN_COIN = coins.Min();

            init_dp(amount);

            int res = SolveDp(amount, coins);

            return res >= INFINITY ? -1 : res;
            
        }

        private int SolveDp(int amount, int[] coins)
        {

            if (amount < 0) {

                return INFINITY;
            }

            if (dp[amount] != -1) { 
                return dp[amount];
            }

            int min = INFINITY;

            foreach (var coin in coins) {
                var cur = SolveDp(amount - coin, coins);
                if (cur < min) {
                    min = cur;
                }
            }

            dp[amount] = min + 1;

            return dp[amount];
        }

        private void init_dp(int amount)
        {
            dp = new int[amount + 1];
            dp[0] = 0;

            int i = 1;
            for (; i < MIN_COIN; i++) {
                dp[i] = INFINITY;
            }

            for (; i < dp.Length; i++)
            {
                dp[i] = -1;
            }

        }
    }
}
