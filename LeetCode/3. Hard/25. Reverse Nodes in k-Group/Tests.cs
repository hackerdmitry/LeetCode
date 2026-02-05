using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._25._Reverse_Nodes_in_k_Group;

[TestFixture(TestName = "25. Reverse Nodes in k-Group")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 2, "[2,1,4,3,5]")]
    [TestCase("[1,2,3,4,5]", 3, "[3,2,1,4,5]")]
    [TestCase("[1,2,3,4,5,6]", 2, "[2,1,4,3,6,5]")]
    [TestCase("[1,2,3,4,5]", 6, "[1,2,3,4,5]")]
    [TestCase("[1,2,3,4,5]", 5, "[5,4,3,2,1]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseKGroup(input1.ParseIntArray(), input2).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
