using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class MaximalSquare_221
    {
        public int MaximalSquare(char[][] matrix)
        {
            int R = matrix.Length;
            int C = matrix[0].Length;

            //convert
            bool hasOne = false;
            for (int r = 0; r < R; r++) {
                for (int c = 0; c < C; c++) {
                    matrix[r][c] -= '0';
                    if (matrix[r][c] == 1) { 
                        hasOne= true;
                    }
                }
            }

            int max = 0;
            if (hasOne)
            {
                max = 1;
            }

            if (R == 1 || C == 1)
            {
                return max;
            }

            for (int r = R - 2; r >= 0;  r--) {
                for (int c = C - 2; c >= 0; c--) {
                    int val = matrix[r][c];
                    int cur = Math.Min(Math.Min(matrix[r][c + 1], matrix[r + 1][c]), matrix[r + 1][c + 1]) * val + val;
                    if (cur > max) { 
                        max = cur;
                    }
                    matrix[r][c] = (char) cur;
                }
            }

            return max;
        }
    }
}
