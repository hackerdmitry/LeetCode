using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2601._Prime_Subtraction_Operation;

[TestFixture(TestName = "2601. Prime Subtraction Operation")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,9,6,10]", true)]
    [TestCase("[6,8,11,12]", true)]
    [TestCase("[5,8,3]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.PrimeSubOperation(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
