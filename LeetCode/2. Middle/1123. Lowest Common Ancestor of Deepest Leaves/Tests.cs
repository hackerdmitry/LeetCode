using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1123._Lowest_Common_Ancestor_of_Deepest_Leaves;

[TestFixture(TestName = "1123. Lowest Common Ancestor of Deepest Leaves")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,null,4,6,null,15,5,10,null,null,null,null,7,11,null,8,12,null,null,null,9,13,14]", "[7, 8, 12, null, 9, 13, 14]")]
    [TestCase("[3,5,1,6,2,0,8,null,null,7,4]", "[2,7,4]")]
    [TestCase("[1]", "[1]")]
    [TestCase("[0,1,3,null,2]", "[2]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LcaDeepestLeaves(input.ParseNullIntArray()).ToArray();
        var expected = output.ParseNullIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
