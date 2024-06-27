using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1791._Find_Center_of_Star_Graph;

[TestFixture(TestName = "1791. Find Center of Star Graph")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2],[2,3],[4,2]]", 2)]
    [TestCase("[[1,2],[5,1],[1,3],[1,4]]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindCenter(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
