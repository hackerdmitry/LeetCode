using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1579._Remove_Max_Number_of_Edges_to_Keep_Graph_Fully_Traversable;

[TestFixture(TestName = "1579. Remove Max Number of Edges to Keep Graph Fully Traversable")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[3,1,2],[3,2,3],[1,1,3],[1,2,4],[1,1,2],[2,3,4]]", 2)]
    [TestCase(4, "[[3,1,2],[3,2,3],[1,1,4],[2,1,4]]", 0)]
    [TestCase(4, "[[3,2,3],[1,1,2],[2,3,4]]", -1)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxNumEdgesToRemove(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
