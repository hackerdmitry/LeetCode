using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3820._Pythagorean_Distance_Nodes_in_a_Tree;

[TestFixture(TestName = "3820. Pythagorean Distance Nodes in a Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[0,1],[1,2],[2,3]]", 0, 3, 2, 0)]
    [TestCase(4, "[[0,1],[0,2],[0,3]]", 1, 2, 3, 3)]
    [TestCase(4, "[[0,1],[1,2],[1,3]]", 1, 3, 0, 1)]
    public void Test(int input1, string input2, int input3, int input4, int input5, int output)
    {
        var solution = new Solution();
        var actual = solution.SpecialNodes(input1, input2.ParseIntArray2d(), input3, input4, input5);
        Assert.AreEqual(output, actual);
    }
}
