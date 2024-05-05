using System.Text;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._606._Construct_String_from_Binary_Tree;

public class Solution
{
    public string Tree2str(TreeNode root)
    {
        return Tree2StringBuilder(root).ToString();
    }

    private StringBuilder Tree2StringBuilder(TreeNode node)
    {
        if (node == null)
            return new StringBuilder();

        var result = new StringBuilder(node.val.ToString());

        if (node.right != null)
        {
            AppendWrappedParenthesis(result, Tree2StringBuilder(node.left));
            AppendWrappedParenthesis(result, Tree2StringBuilder(node.right));
        }
        else if (node.left != null)
            AppendWrappedParenthesis(result, Tree2StringBuilder(node.left));

        return result;
    }

    private StringBuilder AppendWrappedParenthesis(StringBuilder stringBuilder, StringBuilder val) =>
        stringBuilder
            .Append('(')
            .Append(val)
            .Append(')');
}