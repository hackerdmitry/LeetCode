using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1007._Minimum_Domino_Rotations_For_Equal_Row;

[TestFixture(TestName = "1007. Minimum Domino Rotations For Equal Row")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,2,4,2,2]", "[5,2,6,2,3,2]", 2)]
    [TestCase("[3,5,1,2,3]", "[3,6,3,3,4]", -1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinDominoRotations(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}