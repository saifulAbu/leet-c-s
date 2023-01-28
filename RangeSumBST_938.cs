using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{

    internal class RangeSumBST_938
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null) {
                return 0;
            }
            int sum = 0;
            int curVal = root.val;
            if (low <= curVal && curVal <= high) {
                Console.WriteLine("taking : " + curVal);
                sum = curVal;
            }

            if (curVal <= low) {
                sum += RangeSumBST(root.right, low, high);
            } else if (high <= curVal) {
                sum += RangeSumBST(root.left, low, high);
            } else
            {
                sum += RangeSumBST(root.left, low, high);
                sum += RangeSumBST(root.right, low, high);
            }

            return sum; 
        }
    }
}
