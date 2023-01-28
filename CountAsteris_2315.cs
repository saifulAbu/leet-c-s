using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class CountAsteris_2315
    {
        public int CountAsterisks(string s)
        {
            int astCount = 0;
            int barCount= 0;

            foreach(char ch in s){
                if (ch == '|') { 
                    barCount++;
                    continue;
                }
                if (barCount % 2 == 0 && ch == '*') { 
                    astCount++;
                }
            }

            return astCount;

        }
    }
}
