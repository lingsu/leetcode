using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.tree
{
    /// <summary>
    /// 路径总和
    /// </summary>
    public class path_sum
    {
        [Fact]
        public void 路径总和()
        {

        }
        //给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。

        //说明: 叶子节点是指没有子节点的节点。
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return root.val == sum;
            }

            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }

    }
}
