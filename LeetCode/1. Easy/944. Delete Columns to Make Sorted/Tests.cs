using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._944._Delete_Columns_to_Make_Sorted;

[TestFixture(TestName = "944. Delete Columns to Make Sorted")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"cba\",\"daf\",\"ghi\"]", 1)]
    [TestCase("[\"a\",\"b\"]", 0)]
    [TestCase("[\"zyx\",\"wvu\",\"tsr\"]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinDeletionSize(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}