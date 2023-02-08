using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class LongestCommonSubSeq_1143
    {
        Dictionary<int, int> dp = new Dictionary<int, int>();
        string t0;
        string t1;
        int R, C;

        public int LongestCommonSubsequence(string text1, string text2)
        {
            t0= text1;
            t1= text2;

            R = text1.Length ;
            C = text2.Length ;

            return ResolveEventArgs(R - 1, C - 1);
        }

        private int ResolveEventArgs(int i, int j)
        {
            if (i < 0 || j < 0) {
                return 0;
            }

            int key = i * C + j ;

            if (!dp.ContainsKey(key))
            {
                if(t0)
            }
            else { 
            
            }
            
        }
    }
}
