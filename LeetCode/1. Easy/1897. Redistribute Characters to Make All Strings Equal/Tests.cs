using NUnit.Framework;

namespace LeetCode._1._Easy._1897._Redistribute_Characters_to_Make_All_Strings_Equal;

[TestFixture(TestName = "1897. Redistribute Characters to Make All Strings Equal")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"abc","aabc","bc"}, true)]
    [TestCase(new[]{"ab","a"}, false)]
    [TestCase(new[]{"a","a","a"}, true)]
    [TestCase(new[]{"a","b"}, false)]
    public void Test(string[] input, bool output)
    {
        var solution = new Solution();
        var actual = solution.MakeEqual(input);
        Assert.AreEqual(output, actual);
    }
}
