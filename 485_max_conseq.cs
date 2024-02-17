using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _485_max_conseq
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConseq = 0;
            int curConseq = 0;

            foreach (int num in nums)
            {
                if (num == 1)
                {
                    curConseq++;
                    if (curConseq > maxConseq)
                    {
                        maxConseq = curConseq;
                    }
                }
                else
                {
                    curConseq = 0;
                }
            }

            return maxConseq;
        }
    }
}
