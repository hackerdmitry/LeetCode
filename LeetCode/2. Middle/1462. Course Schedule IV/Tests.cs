using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1462._Course_Schedule_IV;

[TestFixture(TestName = "1462. Course Schedule IV")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[2,3],[2,1],[0,3],[0,1]]", "[[0,1],[0,3],[2,3],[3,0],[2,0],[0,2]]", "[true,true,true,false,false,false]")]
    [TestCase(3, "[[1,2],[1,0],[2,0]]", "[[1,0],[1,2]]", "[true,true]")]
    [TestCase(2, "[[1,0]]", "[[0,1],[1,0]]", "[false,true]")]
    [TestCase(2, "[]", "[[1,0],[0,1]]", "[false,false]")]
    public void Test(int input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.CheckIfPrerequisite(input1, input2.ParseIntArray2d(), input3.ParseIntArray2d());
        var expected = output.ParseBoolArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
