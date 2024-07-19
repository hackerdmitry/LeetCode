using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1380._Lucky_Numbers_in_a_Matrix;

[TestFixture(TestName = "1380. Lucky Numbers in a Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[3,7,8],[9,11,13],[15,16,17]]", "[15]")]
    [TestCase("[[1,10,4,2],[9,3,8,7],[15,16,17,12]]", "[12]")]
    [TestCase("[[7,8],[1,2]]", "[7]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LuckyNumbers(input.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
