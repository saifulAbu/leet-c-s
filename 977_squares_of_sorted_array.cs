using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class _977_squares_of_sorted_array
    {
        public int[] SortedSquares(int[] nums)
        {
            //square the input array
            for (int k = 0; k < nums.Length; k++) 
            {
                nums[k] = nums[k] * nums[k];
            }

            // find input for minimum
            int minIndex = 0;
            int min = int.MaxValue;
            for (int k = 0; k < nums.Length; k++) {
                if (nums[k] < min)
                { 
                    min = nums[k];
                    minIndex = k;
                }
            }

            // copy into result array
            int[] res = new int[nums.Length];
            res[0] = nums[minIndex];
            int left = minIndex - 1, right = minIndex + 1;

            int i = 1;
            while (left >=0 &&  right < res.Length) 
            {
                res[i++] = (nums[left] <= nums[right] ? nums[left--] : nums[right++]);
            }

            while (left >= 0)
            {
                res[i++] = nums[left--];
            }

            while (right < res.Length)
            {
                res[i++] = nums[right++];
            }

            return res;
        }
    }
}
