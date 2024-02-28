using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _26_RemoveDupsSortedArr
    {
        public int RemoveDuplicates(int[] arr)
        {
            int k = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[k - 1] != arr[i]) {
                    arr[k++] = arr[i];
                }
            }
            return k;
        }
    }
}
