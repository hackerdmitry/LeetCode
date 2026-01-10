using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2215._Find_the_Difference_of_Two_Arrays;

[TestFixture(TestName = "2215. Find the Difference of Two Arrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3]", "[2,4,6]", "[[1,3],[4,6]]")]
    [TestCase("[1,2,3,3]", "[1,1,2,2]", "[[3],[]]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.FindDifference(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}
