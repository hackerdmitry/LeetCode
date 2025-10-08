using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2300._Successful_Pairs_of_Spells_and_Potions;

[TestFixture(TestName = "2300. Successful Pairs of Spells and Potions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,1,3]", "[1,2,3,4,5]", 7, "[4,0,3]")]
    [TestCase("[3,1,2]", "[8,5,8]", 16, "[2,0,2]")]
    public void Test(string input1, string input2, long input3, string output)
    {
        var solution = new Solution();
        var actual = solution.SuccessfulPairs(input1.ParseIntArray(), input2.ParseIntArray(), input3);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
