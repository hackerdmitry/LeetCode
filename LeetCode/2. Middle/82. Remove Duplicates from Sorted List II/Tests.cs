using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._82._Remove_Duplicates_from_Sorted_List_II;

[TestFixture(TestName = "82. Remove Duplicates from Sorted List II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,3,4,4,5]", "[1,2,5]")]
    [TestCase("[1,1,1,2,3]", "[2,3]")]
    [TestCase("[1,2,3,3,3]", "[1,2]")]
    [TestCase("[1,2,3,3,4,4]", "[1,2]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.DeleteDuplicates(input.ParseIntArray()).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
