using NUnit.Framework;

namespace LeetCode._1503._Last_Moment_Before_All_Ants_Fall_Out_of_a_Plank;

[TestFixture(TestName = "1503. Last Moment Before All Ants Fall Out of a Plank")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, new[]{4,3}, new[]{0,1}, 4)]
    [TestCase(7, new int[0], new[]{0,1,2,3,4,5,6,7}, 7)]
    [TestCase(7, new[]{0,1,2,3,4,5,6,7}, new int[0], 7)]
    [TestCase(11, new[]{1,4,5,10,9}, new[]{2,7,6,3}, 10)]
    public void Test(int input1, int[] input2, int[] input3, int output)
    {
        var solution = new Solution();
        var actual = solution.GetLastMoment(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}
