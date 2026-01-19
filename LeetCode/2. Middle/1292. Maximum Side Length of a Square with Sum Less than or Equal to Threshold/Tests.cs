using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1292._Maximum_Side_Length_of_a_Square_with_Sum_Less_than_or_Equal_to_Threshold;

[TestFixture(TestName = "1292. Maximum Side Length of a Square with Sum Less than or Equal to Threshold")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,2,2,2,2],[2,2,2,2,2],[2,2,2,2,2],[2,2,2,2,2],[2,2,2,2,2]]", 1, 0)]
    [TestCase("[[1,1,3,2,4,3,2],[1,1,3,2,4,3,2],[1,1,3,2,4,3,2]]", 4, 2)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxSideLength(input1.ParseIntArray2d(), input2);
        Assert.AreEqual(output, actual);
    }
}
