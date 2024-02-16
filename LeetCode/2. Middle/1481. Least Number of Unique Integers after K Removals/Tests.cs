using NUnit.Framework;

namespace LeetCode._2._Middle._1481._Least_Number_of_Unique_Integers_after_K_Removals;

[TestFixture(TestName = "1481. Least Number of Unique Integers after K Removals")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{5,5,4}, 1, 1)]
    [TestCase(new[]{4,3,1,1,3,3,2}, 3, 2)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindLeastNumOfUniqueInts(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
