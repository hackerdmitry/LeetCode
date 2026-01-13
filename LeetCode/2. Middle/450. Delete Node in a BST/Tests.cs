using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._450._Delete_Node_in_a_BST;

[TestFixture(TestName = "450. Delete Node in a BST")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3]", 2, "[3,1]")]
    [TestCase("[5,3,6,2,4,null,7]", 3, "[5,4,6,2,null,null,7]")]
    [TestCase("[5,3,6,2,4,null,7]", 0, "[5,3,6,2,4,null,7]")]
    [TestCase("[]", 0, "[]")]
    [TestCase("[20,10,50,null,15,40,null,12,null,null,45]", 20, "[40,10,50,null,15,45,null,12]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.DeleteNode(input1.ParseNullIntArray(), input2).ToArray();
        var expected = output.ParseNullIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
