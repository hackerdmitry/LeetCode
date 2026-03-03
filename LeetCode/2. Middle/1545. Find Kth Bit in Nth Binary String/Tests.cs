using NUnit.Framework;

namespace LeetCode._2._Middle._1545._Find_Kth_Bit_in_Nth_Binary_String;

[TestFixture(TestName = "1545. Find Kth Bit in Nth Binary String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, 1, '0')]
    [TestCase(4, 11, '1')]
    public void Test(int input1, int input2, char output)
    {
        var solution = new Solution();
        var actual = solution.FindKthBit(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
