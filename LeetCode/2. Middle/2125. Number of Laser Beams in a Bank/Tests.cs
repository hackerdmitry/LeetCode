using NUnit.Framework;

namespace LeetCode._2._Middle._2125._Number_of_Laser_Beams_in_a_Bank;

[TestFixture(TestName = "2125. Number of Laser Beams in a Bank")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"011001","000000","010100","001000"}, 8)]
    [TestCase(new[]{"000","111","000"}, 0)]
    public void Test(string[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfBeams(input);
        Assert.AreEqual(output, actual);
    }
}
