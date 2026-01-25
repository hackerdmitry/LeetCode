using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3819._Rotate_Non_Negative_Elements;

[TestFixture(TestName = "3819. Rotate Non Negative Elements")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,-2,3,-4]", 3, "[3,-2,1,-4]")]
    [TestCase("[-3,-2,7]", 1, "[-3,-2,7]")]
    [TestCase("[5,4,-9,6]", 2, "[6,5,-9,4]")]
    [TestCase("[-6,-2]", 18866, "[-6,-2]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RotateElements(input1.ParseIntArray(), input2);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
