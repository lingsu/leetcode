using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace Leetcode.tree
{
    /// <summary>
    /// 相同的树
    /// </summary>
    public class same_tree
    {

        //给定两个二叉树，编写一个函数来检验它们是否相同。

        //如果两个树在结构上相同，并且节点具有相同的值，则认为它们是相同的。
        [Fact]
        public void 相同的树()
        {
            IsSameTree(new TreeNode(), new TreeNode());
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (q == null && p == null)
            {
                return true;
            }
            else if (q == null || p == null)
            {
                return false;
            }
            else if (q.val != p.val)
            {
                return false;
            }

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        public class TreeNode
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

    }
}
