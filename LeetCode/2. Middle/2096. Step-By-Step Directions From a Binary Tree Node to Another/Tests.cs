using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2096._Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another;

[TestFixture(TestName = "2096. Step-By-Step Directions From a Binary Tree Node to Another")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,1,2,3,null,6,4]", 3, 6, "UURL")]
    [TestCase("[2,1]", 2, 1, "L")]
    public void Test(string input1, int input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.GetDirections(input1.ParseNullIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}