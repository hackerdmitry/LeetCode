using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3217._Delete_Nodes_From_Linked_List_Present_in_Array;

[TestFixture(TestName = "3217. Delete Nodes From Linked List Present in Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,7,6,2,4]", "[3,7,1,8,1]", "[3,8]")]
    [TestCase("[1,2,3]", "[1,2,3,4,5]", "[4,5]")]
    [TestCase("[1]", "[1,2,1,2,1,2]", "[2,2,2]")]
    [TestCase("[5]", "[1,2,3,4]", "[1,2,3,4]")]
    [TestCase("[1]", "[1]", "[]")]
    [TestCase("[1]", "[3,2,1]", "[3,2]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ModifiedList(input1.ParseIntArray(), input2.ParseIntArray()).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
