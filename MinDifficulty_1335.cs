using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class MinDifficulty_1335
    {
        int[,] maxCost;
        int[,] dp;
        int N;

        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            N = jobDifficulty.Length;

            if (N < d) {
                return -1;
            }

            Setup_MaxCost(jobDifficulty);
            Init_Dp(jobDifficulty, d);

            return SolveDp(0, d);
        }

        private int SolveDp(int start, int days)
        {
            if (dp[start, days] != -1) { 
                return dp[start, days];
            }

            int minCost = int.MaxValue;

            for (int i = start + 1; N - i >= days - 1; i++) { 
                var cur = maxCost[start, i-1] + SolveDp(i, days - 1);
                if (cur < minCost) {
                    minCost = cur;
                }
            }

            dp[start, days] = minCost;
            return minCost;
        }

        private void Init_Dp(int[] jobDifficulty, int d)
        {
            dp = new int[N, d + 1];
            for (int r = 0; r < N; r++) {
                for (int c = 0; c <= d; c++)
                {
                    dp[r, c] = -1;
                }
            }

            for (int start = 0; start < N; start++) {
                dp[start,1] = maxCost[start, N - 1];
            }

            Console.WriteLine();
            for (int r = 0; r < dp.GetLength(0); r++) {
                for (int c = 0; c < dp.GetLength(1); c++) {
                    Console.Write(dp[r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        private void Setup_MaxCost(int[] jobDifficulty) {

            maxCost = new int[N, N];

            //initialize val
            for (int r = 0; r < N; r++) {
                maxCost[r, r] = jobDifficulty[r];
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = r + 1; c < N; c++)
                {
                    maxCost[r, c] = Math.Max(maxCost[r, c-1], jobDifficulty[c]); 
                }
            }

            // print min cost
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write(maxCost[r, c] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
