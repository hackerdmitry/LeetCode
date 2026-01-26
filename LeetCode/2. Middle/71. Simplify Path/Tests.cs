using NUnit.Framework;

namespace LeetCode._2._Middle._71._Simplify_Path;

[TestFixture(TestName = "71. Simplify Path")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("/home/", "/home")]
    [TestCase("/home//foo/", "/home/foo")]
    [TestCase("/home/user/Documents/../Pictures", "/home/user/Pictures")]
    [TestCase("/../", "/")]
    [TestCase("/.../a/../b/c/../d/./", "/.../b/d")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SimplifyPath(input);
        Assert.AreEqual(output, actual);
    }
}
