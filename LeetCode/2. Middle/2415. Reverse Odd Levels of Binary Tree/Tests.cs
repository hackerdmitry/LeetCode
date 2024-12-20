using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2415._Reverse_Odd_Levels_of_Binary_Tree;

[TestFixture(TestName = "2415. Reverse Odd Levels of Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[7,13,11]", "[7,11,13]")]
    [TestCase("[2,3,5,8,13,21,34]", "[2,5,3,8,13,21,34]")]
    [TestCase("[0,1,2,0,0,0,0,1,1,1,1,2,2,2,2]", "[0,2,1,0,0,0,0,2,2,2,2,1,1,1,1]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseOddLevels(input.ParseNullIntArray()).ToArray();
        actual.WriteLine("actual");
        var expected = output.ParseNullIntArray();
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
