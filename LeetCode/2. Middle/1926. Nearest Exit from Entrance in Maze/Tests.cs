using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1926._Nearest_Exit_from_Entrance_in_Maze;

[TestFixture(TestName = "1926. Nearest Exit from Entrance in Maze")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[['+','+','.','+'],['.','.','.','+'],['+','+','+','.']]", "[1,2]", 1)]
    [TestCase("[['+','+','+'],['.','.','.'],['+','+','+']]", "[1,0]", 2)]
    [TestCase("[['.','+']]", "[0,0]", -1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.NearestExit(input1.ParseCharArray2d(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
