using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.tree
{
    /// <summary>
    /// 翻转二叉树
    /// </summary>
    public class invert_binary_tree
    {
        [Fact]
        public void 翻转二叉树()
        {

        }
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            var left = root.left;
            root.left = root.right;
            root.right = left;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
