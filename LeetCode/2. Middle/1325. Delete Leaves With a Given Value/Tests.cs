using System;
using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1325._Delete_Leaves_With_a_Given_Value;

[TestFixture(TestName = "1325. Delete Leaves With a Given Value")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,2,null,2,4]", 2, "[1,null,3,null,4]")]
    [TestCase("[1,3,3,3,2]", 3, "[1,3,null,null,2]")]
    [TestCase("[1,2,null,2,null,2]", 2, "[1]")]
    [TestCase("[1,1,1]", 1, "[]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RemoveLeafNodes(input1.ParseNullIntArray(), input2).ToArray();
        var expected = output.ParseNullIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
