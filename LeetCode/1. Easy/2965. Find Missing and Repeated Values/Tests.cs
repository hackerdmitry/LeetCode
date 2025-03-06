using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2965._Find_Missing_and_Repeated_Values;

[TestFixture(TestName = "2965. Find Missing and Repeated Values")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,3],[2,2]]", "[2,4]")]
    [TestCase("[[9,1,7],[8,9,2],[3,4,6]]", "[9,5]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.FindMissingAndRepeatedValues(input.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
