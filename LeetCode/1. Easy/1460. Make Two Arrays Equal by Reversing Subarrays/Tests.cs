using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1460._Make_Two_Arrays_Equal_by_Reversing_Subarrays;

[TestFixture(TestName = "1460. Make Two Arrays Equal by Reversing Subarrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4]", "[2,4,1,3]", true)]
    [TestCase("[7]", "[7]", true)]
    [TestCase("[3,7,9]", "[3,7,11]", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanBeEqual(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}