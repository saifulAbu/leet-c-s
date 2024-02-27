using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _88_MergeSortedArray
    {
        public void Merge(int[] arr0, int m, int[] arr1, int n)
        {
            int i0 = m - 1, i1 = n - 1, i = m + n - 1;

            while (i0 >= 0 && i1 >= 0)
            {
                arr0[i--] = arr0[i0] >= arr1[i1] ? arr0[i0--] : arr1[i1--];
            }

            while (i0 >= 0)
            {
                arr0[i--] = arr0[i0--];
            }

            while (i1 >= 0)
            {
                arr0[i--] = arr1[i1--];
            }
        }
    }
}
