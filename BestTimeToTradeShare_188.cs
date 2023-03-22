using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class BestTimeToTradeShare_188
    {
        int[][] dp;
        public int MaxProfit(int k, int[] prices)
        {
            dp = new int[k * 2 + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[prices.Length];
            }

            //initialize to -1
            for (int r = 0; r < dp.Length; r++) {
                for (int c = 0; c < dp[0].Length; c++) {
                    dp[r][c] = -1;
                }
            }

            return DPMaxProfit(0, prices, k * 2);
        }

        public int DPMaxProfit(int start, int[] prices, int remainingTransactions) {
            if (start == prices.Length || remainingTransactions == 0) { 
                return 0;
            }

            if (dp[remainingTransactions][start] != -1) { 
                return dp[remainingTransactions][start]; 
            }

            int profitWithTransaction = DPMaxProfit(start + 1, prices, remainingTransactions - 1);
            if (remainingTransactions % 2 == 0) // sell
            {
                profitWithTransaction -= prices[start];
            }
            else { // buy 
                profitWithTransaction += prices[start];
            }

            int noActionProfit = DPMaxProfit(start + 1, prices, remainingTransactions);

            dp[remainingTransactions][start] = Math.Max(profitWithTransaction, noActionProfit);

            return dp[remainingTransactions][start];
        }
    }
}
