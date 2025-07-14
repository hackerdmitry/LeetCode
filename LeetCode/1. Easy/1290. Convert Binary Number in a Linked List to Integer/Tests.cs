using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1290._Convert_Binary_Number_in_a_Linked_List_to_Integer;

[TestFixture(TestName = "1290. Convert Binary Number in a Linked List to Integer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,1]", 5)]
    [TestCase("[0]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.GetDecimalValue(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
