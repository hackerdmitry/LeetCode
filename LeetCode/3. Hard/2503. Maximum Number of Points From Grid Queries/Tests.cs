using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._2503._Maximum_Number_of_Points_From_Grid_Queries;

[TestFixture(TestName = "2503. Maximum Number of Points From Grid Queries")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,3],[2,5,7],[3,5,1]]", "[5,6,2]", "[5,8,1]")]
    [TestCase("[[5,2,1],[1,1,2]]", "[3]", "[0]")]
    [TestCase("[[8]]", "[9]", "[1]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.MaxPoints(input1.ParseIntArray2d(), input2.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split(' ');
        Test(inputs[0], inputs[1], output);
    }
}
