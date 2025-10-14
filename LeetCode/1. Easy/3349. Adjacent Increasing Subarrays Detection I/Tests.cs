using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3349._Adjacent_Increasing_Subarrays_Detection_I;

[TestFixture(TestName = "3349. Adjacent Increasing Subarrays Detection I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-15,19]", 1, true)]
    [TestCase("[19,-15]", 1, true)]
    [TestCase("[2,5,7,8,9,2,3,4,3,1]", 3, true)]
    [TestCase("[1,2,3,4,4,4,4,5,6,7]", 5, false)]
    public void Test(string input1, int input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.HasIncreasingSubarrays(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
