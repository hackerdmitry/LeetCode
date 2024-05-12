using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._19._Remove_Nth_Node_From_End_of_List;

[TestFixture(TestName = "19. Remove Nth Node From End of List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 2, "[1,2,3,5]")]
    [TestCase("[1]", 1, "[]")]
    [TestCase("[1,2]", 1, "[1]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RemoveNthFromEnd(input1.ParseIntArray(), input2).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}