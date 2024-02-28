using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _27_RemoveElements
    {
        public int RemoveElement(int[] arr, int val)
        {
            int k = 0;
            while (k < arr.Length && arr[k] != val) {
                k++;
            }

            for (int i = k;  i < arr.Length; i++)
            {
                if (arr[i] != val) 
                {
                    arr[k++] = arr[i];
                }
            }

            return k;
        }
    }
}
