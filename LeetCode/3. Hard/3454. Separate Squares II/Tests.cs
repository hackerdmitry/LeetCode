using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._3454._Separate_Squares_II;

[TestFixture(TestName = "3454. Separate Squares II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,2],[2,2,2]]", 2)]
    [TestCase("[[0,0,1],[2,2,1]]", 1.00000)]
    [TestCase("[[0,0,2]]", 1)]
    [TestCase("[[0,0,2],[1,1,1]]", 1.00000)]
    [TestCase("[[0,0,2],[2,1,1]]", 1.16667)]
    [TestCase("[[0,0,2],[3,1,1],[4,1,1]]", 1.25000)]
    public void Test(string input, double output)
    {
        var solution = new Solution();
        var actual = solution.SeparateSquares(input.ParseIntArray2d());
        Assert.AreEqual(output, actual, 10e-5);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, double.Parse(output));
    }
}
