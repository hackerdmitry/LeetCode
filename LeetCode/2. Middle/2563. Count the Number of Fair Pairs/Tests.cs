using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2563._Count_the_Number_of_Fair_Pairs;

[TestFixture(TestName = "2563. Count the Number of Fair Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,1,7,4,4,5]", 3, 6, 6)]
    [TestCase("[1,7,9,2,5]", 11, 11, 1)]
    [TestCase("[1,7,9,2,5,22]", 11, 11, 1)]
    public void Test(string input1, int input2, int input3, long output)
    {
        var solution = new Solution();
        var actual = solution.CountFairPairs(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
