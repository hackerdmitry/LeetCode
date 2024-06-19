using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1482._Minimum_Number_of_Days_to_Make_m_Bouquets;

[TestFixture(TestName = "1482. Minimum Number of Days to Make m Bouquets")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,10,3,10,2]", 3, 1, 3)]
    [TestCase("[1,10,3,10,2]", 3, 2, -1)]
    [TestCase("[7,7,7,7,12,7,7]", 2, 3, 12)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MinDays(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
