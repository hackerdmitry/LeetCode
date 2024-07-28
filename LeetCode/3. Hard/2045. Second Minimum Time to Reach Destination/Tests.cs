using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2045._Second_Minimum_Time_to_Reach_Destination;

[TestFixture(TestName = "2045. Second Minimum Time to Reach Destination")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, "[[1,2],[1,3],[1,4],[3,4],[4,5]]", 3, 5, 13)]
    [TestCase(2, "[[1,2]]", 3, 2, 11)]
    public void Test(int input1, string input2, int input3, int input4, int output)
    {
        var solution = new Solution();
        var actual = solution.SecondMinimum(input1, input2.ParseIntArray2d(), input3, input4);
        Assert.AreEqual(output, actual);
    }
}