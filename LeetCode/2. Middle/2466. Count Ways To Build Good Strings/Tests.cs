using NUnit.Framework;

namespace LeetCode._2._Middle._2466._Count_Ways_To_Build_Good_Strings;

[TestFixture(TestName = "2466. Count Ways To Build Good Strings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, 3, 1, 1, 8)]
    [TestCase(2, 3, 1, 2, 5)]
    public void Test(int input1, int input2, int input3, int input4, int output)
    {
        var solution = new Solution();
        var actual = solution.CountGoodStrings(input1, input2, input3, input4);
        Assert.AreEqual(output, actual);
    }
}
