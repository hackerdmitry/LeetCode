using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3394._Check_if_Grid_can_be_Cut_into_Sections;

[TestFixture(TestName = "3394. Check if Grid can be Cut into Sections")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[0,2,2,4],[1,0,3,2],[2,2,3,4],[3,0,4,2],[3,2,4,4]]", false)]
    [TestCase(5, "[[1,0,5,2],[0,2,2,4],[3,2,5,3],[0,4,4,5]]", true)]
    [TestCase(4, "[[0,0,1,1],[2,0,3,4],[0,2,2,3],[3,0,4,3]]", true)]
    public void Test(int input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CheckValidCuts(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
