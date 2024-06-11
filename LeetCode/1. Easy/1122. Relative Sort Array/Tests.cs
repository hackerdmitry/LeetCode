using System;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1122._Relative_Sort_Array;

[TestFixture(TestName = "1122. Relative Sort Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,1,3,2,4,6,7,9,2,19]", "[2,1,4,3,9,6]", "[2,2,2,1,4,3,3,9,6,7,19]")]
    [TestCase("[28,6,22,8,44,17]", "[22,28,8,6]", "[22,28,8,6,17,44]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RelativeSortArray(input1.ParseIntArray(), input2.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
