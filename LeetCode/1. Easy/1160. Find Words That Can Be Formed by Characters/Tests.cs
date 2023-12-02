using NUnit.Framework;

namespace LeetCode._1._Easy._1160._Find_Words_That_Can_Be_Formed_by_Characters;

[TestFixture(TestName = "1160. Find Words That Can Be Formed by Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"cat","bt","hat","tree"}, "atach", 6)]
    [TestCase(new[]{"hello","world","leetcode"}, "welldonehoneyr", 10)]
    public void Test(string[] input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountCharacters(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
