using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class MinDifficulty_1335
    {
        int[,] maxCost;
        int N;

        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            Setup_MaxCost(jobDifficulty);

            return 0;
        }

        private void Setup_MaxCost(int[] jobDifficulty) {
            N = jobDifficulty.Length;

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
