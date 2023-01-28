using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class IsSameTree_100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p != null && q != null && p.val == q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            else if (p == null && q == null)
            {
                return true;
            }
            else { 
                return false;
            }
        }
    }
}
