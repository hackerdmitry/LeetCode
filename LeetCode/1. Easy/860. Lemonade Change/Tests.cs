using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._860._Lemonade_Change;

[TestFixture(TestName = "860. Lemonade Change")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,5,5,10,20]", true)]
    [TestCase("[5,5,10,10,20]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.LemonadeChange(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}