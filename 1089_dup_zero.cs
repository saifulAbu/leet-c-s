using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _1089_dup_zero
    {
        public void DuplicateZeros(int[] arr)
        {
            Queue<int> q = new Queue<int>();

            int i = 0;
            while (i < arr.Length)
            {
                q.Enqueue(arr[i]);
                int cur = q.Dequeue();
                arr[i++] = cur;
                if (cur == 0 && i < arr.Length) {
                    q.Enqueue(arr[i]);
                    arr[i++] = cur;
                }
            }
        }
    }
}
