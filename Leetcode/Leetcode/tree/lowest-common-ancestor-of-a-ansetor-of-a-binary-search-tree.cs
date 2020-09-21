using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.tree
{
    /// <summary>
    /// 二叉搜索树的最近公共祖先
    /// </summary>
    public class lowest_common_ancestor_of_a_ansetor_of_a_binary_search_tree
    {
        [Fact]
        public void 二叉搜索树的最近公共祖先()
        {

        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var pv = p.val;
            var qv = q.val;

            if (pv > root.val && qv > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else if (pv < root.val && qv < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }

            return root;
        }
    }
}
