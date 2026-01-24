using NUnit.Framework;

namespace LeetCode._1._Easy._205._Isomorphic_Strings;

[TestFixture(TestName = "205. Isomorphic Strings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("badc", "baba", false)]
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    [TestCase("paper", "title", true)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsIsomorphic(input1, input2);
        Assert.AreEqual(output, actual);
    }
}