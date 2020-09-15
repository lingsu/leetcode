using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Leetcode.tree
{
    /// <summary>
    /// 二叉树的层次遍历 II
    /// </summary>
    public class binary_tree_level_order_traversal_ii
    {
        [Fact]
        public void 二叉树的层次遍历II()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            //var ss = LevelOrderBottom(root);

            //var root2 = new TreeNode(1);
            //root2.left = new TreeNode(2);
            //root2.right = new TreeNode(3);
            //root2.left.right = new TreeNode(4);
            //root2.right.left = new TreeNode(5);

            var level = LevelOrderBottom(root);
            //LevelOrderBottom(root).ShouldBe()
        }

        private IList<IList<int>> Result = new List<IList<int>>();
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            Dfs(root);
            return Result;
        }
        private void Dfs(TreeNode root)
        {
            if (root==null)
            {
                return;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var level = new List<int>();
                var count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                Result.Insert(0, level);
            }
        }
      
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
