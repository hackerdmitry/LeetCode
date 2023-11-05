using NUnit.Framework;

namespace LeetCode._1535._Find_the_Winner_of_an_Array_Game;

[TestFixture(TestName = "1535. Find the Winner of an Array Game")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{2,1,3,5,4,6,7}, 2, 5)]
    [TestCase(new[]{3,2,1}, 10, 3)]
    [TestCase(new[]{3,2,1,5,4,6,7}, 2, 3)]
    [TestCase(new[]{3,2,1,7,4,6,5}, 3, 7)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.GetWinner(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
