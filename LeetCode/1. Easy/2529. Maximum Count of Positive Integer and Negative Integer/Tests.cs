using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2529._Maximum_Count_of_Positive_Integer_and_Negative_Integer;

[TestFixture(TestName = "2529. Maximum Count of Positive Integer and Negative Integer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-2,-1,-1,1,2,3]", 3)]
    [TestCase("[-3,-2,-1,0,0,1,2]", 3)]
    [TestCase("[5,20,66,1314]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumCount(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
