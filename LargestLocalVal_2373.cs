using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class LargestLocalVal_2373
    {
        int max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        public int[][] LargestLocal(int[][] grid)
        {
            int n = grid.Length;
            int resLen = n - 2;
            //transform 1
            int[][] transform1 = new int[resLen][];
            for (int r = 0; r < resLen; r++)
            {
                transform1[r] = new int[n];
            }

            for (int r = 0; r < resLen; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    transform1[r][c] = max(grid[r][c], grid[r + 1][c], grid[r + 2][c]);
                }
            }

            //transform 2
            int[][] res = new int[resLen][];
            for (int r = 0; r < resLen; r++)
            {
                res[r] = new int[resLen];
            }

            for (int r = 0; r < resLen; r++)
            {
                for (int c = 0; c < resLen; c++)
                {
                    res[r][c] = max(transform1[r][c], transform1[r][c + 1], transform1[r][c + 2]);
                }
            }


            return res;
        }
    }
}
