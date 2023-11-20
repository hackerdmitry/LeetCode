using NUnit.Framework;

namespace LeetCode._2._Middle._2391._Minimum_Amount_of_Time_to_Collect_Garbage;

[TestFixture(TestName = "2391. Minimum Amount of Time to Collect Garbage")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"G","P","GP","GG"}, new[]{2,4,3}, 21)]
    [TestCase(new[]{"MMM","PGM","GP"}, new[]{3,10}, 37)]
    public void Test(string[] input1, int[] input2, int output)
    {
        var solution = new Solution();
        var actual = solution.GarbageCollection(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
