using NUnit.Framework;

namespace LeetCode._2._Middle._1239._Maximum_Length_of_a_Concatenated_String_with_Unique_Characters;

[TestFixture(TestName = "1239. Maximum Length of a Concatenated String with Unique Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"un","iq","ue"}, 4)]
    [TestCase(new[]{"cha","r","act","ers"}, 6)]
    [TestCase(new[]{"abcdefghijklmnopqrstuvwxyz"}, 26)]
    [TestCase(new[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p"}, 16)]
    [TestCase(new[]{"a","b","c","d","e","f","g","h","p","j","k","l","m","n","o","p"}, 15)]
    public void Test(string[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxLength(input);
        Assert.AreEqual(output, actual);
    }
}
