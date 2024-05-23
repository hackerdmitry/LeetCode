using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2597._The_Number_of_Beautiful_Subsets;

[TestFixture(TestName = "2597. The Number of Beautiful Subsets")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,4,6]", 2, 4)]
    [TestCase("[1]", 1, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.BeautifulSubsets(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}