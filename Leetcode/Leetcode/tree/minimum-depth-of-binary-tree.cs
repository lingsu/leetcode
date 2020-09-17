using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.tree
{
    /// <summary>
    /// 二叉树的最小深度
    /// </summary>
    public class minimum_depth_of_binary_tree
    {
        [Fact]
        public void 二叉树的最小深度()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            MinDepth(root).ShouldBe(2);
        }
        [Fact]
        public void 二叉树的最小深度2()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            MinDepth(root).ShouldBe(2);
        }

        //给定一个二叉树，找出其最小深度。
        //最小深度是从根节点到最近叶子节点的最短路径上的节点数量。
        //说明: 叶子节点是指没有子节点的节点。
        public int MinDepth(TreeNode root)
        {
            return Height(root);
        }
        private int Height(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.left == null && node.right == null)
            {
                return 1;
            }
            var minDepth = int.MaxValue;
            if (node.left != null)
            {
                minDepth = Math.Min(Height(node.left), minDepth);
            }
            if (node.right != null)
            {
                minDepth = Math.Min(Height(node.right), minDepth);
            }
            return minDepth + 1;
        }
    }
}
