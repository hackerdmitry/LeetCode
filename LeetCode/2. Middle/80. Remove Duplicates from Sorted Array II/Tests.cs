using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._80._Remove_Duplicates_from_Sorted_Array_II;

[TestFixture(TestName = "80. Remove Duplicates from Sorted Array II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,1,2,2,3]", 5)]
    [TestCase("[0,0,1,1,1,1,2,3,3]", 7)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.RemoveDuplicates(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
