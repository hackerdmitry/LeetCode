using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1072._Flip_Columns_For_Maximum_Number_of_Equal_Rows;

[TestFixture(TestName = "1072. Flip Columns For Maximum Number of Equal Rows")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,0],[0,0,1],[1,1,0]]", 2)]
    [TestCase("[[0,1],[1,1]]", 1)]
    [TestCase("[[0,1],[1,0]]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxEqualRowsAfterFlips(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
