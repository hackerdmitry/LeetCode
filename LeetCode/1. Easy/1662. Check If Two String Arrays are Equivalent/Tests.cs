using NUnit.Framework;

namespace LeetCode._1._Easy._1662._Check_If_Two_String_Arrays_are_Equivalent;

[TestFixture(TestName = "1662. Check If Two String Arrays are Equivalent")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"ab", "c"}, new[]{"a", "bc"}, true)]
    [TestCase(new[]{"a", "cb"},new[]{"ab", "c"}, false)]
    [TestCase(new[]{"abc", "d", "defg"}, new[]{"abcddefg"}, true)]
    public void Test(string[] input1, string[] input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.ArrayStringsAreEqual(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
