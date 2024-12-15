using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1792._Maximum_Average_Pass_Ratio;

[TestFixture(TestName = "1792. Maximum Average Pass Ratio")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2],[3,5],[2,2]]", 2, 0.78333)]
    [TestCase("[[2,4],[3,9],[4,5],[2,10]]", 4, 0.53485)]
    public void Test(string input1, int input2, double output)
    {
        var solution = new Solution();
        var actual = solution.MaxAverageRatio(input1.ParseIntArray2d(), input2);
        Assert.AreEqual(output, actual, 1e-5);
    }
}
