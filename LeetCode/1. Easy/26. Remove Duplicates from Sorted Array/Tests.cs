using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._26._Remove_Duplicates_from_Sorted_Array;

[TestFixture(TestName = "26. Remove Duplicates from Sorted Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,2]", 2)]
    [TestCase("[0,0,1,1,1,2,2,3,3,4]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.RemoveDuplicates(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
