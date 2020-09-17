using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.tree
{
    /// <summary>
    /// 平衡二叉树
    /// </summary>
    public class balanced_binary_tree
    {
        /// <summary>
        /// 给定一个二叉树，判断它是否是高度平衡的二叉树。
        ///本题中，一棵高度平衡二叉树定义为：
        ///一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过1。
        /// </summary>
        [Fact]
        public void 平衡二叉树()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            IsBalanced(root).ShouldBeTrue();
        }
        public bool IsBalanced(TreeNode root)
        {
            return Height(root) >= 0;
        }
        int Height(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            var ldepth = Height(node.left);
            var rdepth = Height(node.right);
            if (ldepth== -1 || rdepth == -1 || Math.Abs(ldepth - rdepth) > 1)
            {
                return -1;
            }
            
            return Math.Max(ldepth, rdepth) + 1;
        }
    }
}
