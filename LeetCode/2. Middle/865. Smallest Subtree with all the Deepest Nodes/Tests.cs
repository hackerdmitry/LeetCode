using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._865._Smallest_Subtree_with_all_the_Deepest_Nodes;

[TestFixture(TestName = "865. Smallest Subtree with all the Deepest Nodes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,5,1,6,2,0,8,null,null,7,4]", "[2,7,4]")]
    [TestCase("[1]", "[1]")]
    [TestCase("[0,1,3,null,2]", "[2]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SubtreeWithAllDeepest(input.ParseNullIntArray());
        Assert.AreEqual(output.ParseNullIntArray(), actual.ToArray());
    }
}
