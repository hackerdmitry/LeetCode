using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._769._Max_Chunks_To_Make_Sorted;

[TestFixture(TestName = "769. Max Chunks To Make Sorted")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,3,2,1,0]", 1)]
    [TestCase("[1,0,2,3,4]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxChunksToSorted(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
