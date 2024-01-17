using NUnit.Framework;

namespace LeetCode._1._Easy._1207._Unique_Number_of_Occurrences;

[TestFixture(TestName = "1207. Unique Number of Occurrences")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,2,1,1,3}, true)]
    [TestCase(new[]{1,2}, false)]
    [TestCase(new[]{-3,0,1,-3,1,1,1,-3,10,0}, true)]
    public void Test(int[] input, bool output)
    {
        var solution = new Solution();
        var actual = solution.UniqueOccurrences(input);
        Assert.AreEqual(output, actual);
    }
}
