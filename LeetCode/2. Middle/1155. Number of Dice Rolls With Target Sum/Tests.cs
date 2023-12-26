using NUnit.Framework;

namespace LeetCode._2._Middle._1155._Number_of_Dice_Rolls_With_Target_Sum;

[TestFixture(TestName = "1155. Number of Dice Rolls With Target Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 6, 3, 1)]
    [TestCase(2, 6, 7, 6)]
    [TestCase(30, 30, 500, 222616187)]
    [TestCase(4, 6, 18, 80)]
    public void Test(int input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.NumRollsToTarget(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}
