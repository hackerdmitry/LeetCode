using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3542._Minimum_Operations_to_Convert_All_Elements_to_Zero;

[TestFixture(TestName = "3542. Minimum Operations to Convert All Elements to Zero")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,2]", 1)]
    [TestCase("[3,1,2,1]", 3)]
    [TestCase("[1,2,1,2,1,2]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
