using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._118._Pascal_s_Triangle;

[TestFixture(TestName = "118. Pascal's Triangle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]")]
    [TestCase(1, "[[1]]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.Generate(input);
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}
