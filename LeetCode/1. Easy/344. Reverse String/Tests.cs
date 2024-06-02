using NUnit.Framework;

namespace LeetCode._1._Easy._344._Reverse_String;

[TestFixture(TestName = "344. Reverse String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {'h', 'e', 'l', 'l', 'o'}, new[] {'o', 'l', 'l', 'e', 'h'})]
    [TestCase(new[] {'H', 'a', 'n', 'n', 'a', 'h'}, new[] {'h', 'a', 'n', 'n', 'a', 'H'})]
    public void Test(char[] input, char[] output)
    {
        var solution = new Solution();
        solution.ReverseString(input);
        Assert.AreEqual(output, input);
    }
}