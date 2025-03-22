using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2685._Count_the_Number_of_Complete_Components;

[TestFixture(TestName = "2685. Count the Number of Complete Components")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[1,0],[2,1]]", 1)]
    [TestCase(6, "[[0,1],[0,2],[1,2],[3,4]]", 3)]
    [TestCase(6, "[[0,1],[0,2],[1,2],[3,4],[3,5]]", 1)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountCompleteComponents(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
