using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1652._Defuse_the_Bomb;

[TestFixture(TestName = "1652. Defuse the Bomb")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,7,1,4]", 3, "[12,10,16,13]")]
    [TestCase("[5,7,1,4]", 1, "[7,1,4,5]")]
    [TestCase("[1,2,3,4]", 0, "[0,0,0,0]")]
    [TestCase("[2,4,9,3]", -2, "[12,5,6,13]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.Decrypt(input1.ParseIntArray(), input2);
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
