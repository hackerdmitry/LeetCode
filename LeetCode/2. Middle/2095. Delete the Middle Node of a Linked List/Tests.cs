using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2095._Delete_the_Middle_Node_of_a_Linked_List;

[TestFixture(TestName = "2095. Delete the Middle Node of a Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,4,7,1,2,6]", "[1,3,4,1,2,6]")]
    [TestCase("[1,2,3,4]", "[1,2,4]")]
    [TestCase("[2,1]", "[2]")]
    [TestCase("[2]", "")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.DeleteMiddle(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual.ToArray());
    }
}
