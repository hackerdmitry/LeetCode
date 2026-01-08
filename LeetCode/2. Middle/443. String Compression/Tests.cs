using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._443._String_Compression;

[TestFixture(TestName = "443. String Compression")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("a", 1, "a")]
    [TestCase("aabbccc", 6, "a2b2c3")]
    [TestCase("abbbbbbbbbbbb", 4, "ab12")]
    [TestCase("oooooooooo", 3, "o10")]
    public void Test(string input, int output, string output2)
    {
        var solution = new Solution();
        var array = input.ToCharArray();
        var actual = solution.Compress(array);
        Assert.AreEqual(output, actual);
        var expected2 = output2.ToCharArray();
        var actual2 = array.Take(actual).ToArray();
        expected2.WriteLine("expected2");
        actual2.WriteLine("actual2");
        Assert.AreEqual(expected2, actual2);
    }
}