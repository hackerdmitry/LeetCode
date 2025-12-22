using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._960._Delete_Columns_to_Make_Sorted_III;

[TestFixture(TestName = "960. Delete Columns to Make Sorted III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"baabab\"]", 2)]
    [TestCase("[\"babca\",\"bbazb\"]", 3)]
    [TestCase("[\"edcba\"]", 4)]
    [TestCase("[\"aaaabaa\"]", 1)]
    [TestCase("[\"ghi\",\"def\",\"abc\"]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinDeletionSize(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}
