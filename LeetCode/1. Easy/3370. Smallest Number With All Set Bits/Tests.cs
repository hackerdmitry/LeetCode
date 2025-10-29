using NUnit.Framework;

namespace LeetCode._1._Easy._3370._Smallest_Number_With_All_Set_Bits;

[TestFixture(TestName = "3370. Smallest Number With All Set Bits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, 7)]
    [TestCase(10, 15)]
    [TestCase(3, 3)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.SmallestNumber(input);
        Assert.AreEqual(output, actual);
    }
}
