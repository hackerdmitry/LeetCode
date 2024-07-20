using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1605._Find_Valid_Matrix_Given_Row_and_Column_Sums;

[TestFixture(TestName = "1605. Find Valid Matrix Given Row and Column Sums")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,8]", "[4,7]", "[[3,0],[1,7]]")]
    [TestCase("[5,7,10]", "[8,6,8]", "[[5,0,0],[3,4,0],[0,2,8]]")]
    [TestCase("[6,18]", "[6,8,10]", "[[6,0,0],[0,8,10]]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RestoreMatrix(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}
