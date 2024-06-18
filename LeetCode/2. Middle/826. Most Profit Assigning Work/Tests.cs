using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._826._Most_Profit_Assigning_Work;

[TestFixture(TestName = "826. Most Profit Assigning Work")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,4,6,8,10]", "[10,20,30,40,50]", "[4,5,6,7]", 100)]
    [TestCase("[85,47,57]", "[24,66,99]", "[40,25,25]", 0)]
    [TestCase("[68,35,52,47,86]", "[67,17,1,81,3]", "[92,10,85,84,82]", 324)]
    public void Test(string input1, string input2, string input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProfitAssignment(input1.ParseIntArray(), input2.ParseIntArray(), input3.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
