using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1233._Remove_Sub_Folders_from_the_Filesystem;

[TestFixture(TestName = "1233. Remove Sub-Folders from the Filesystem")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"/a\",\"/a/b/c\",\"/a/b/d\"]", "[\"/a\"]")]
    [TestCase("[\"/a\",\"/a/b\",\"/c/d\",\"/c/d/e\",\"/c/f\"]", "[\"/a\",\"/c/d\",\"/c/f\"]")]
    [TestCase("[\"/a/b/c\",\"/a/b/ca\",\"/a/b/d\"]", "[\"/a/b/c\",\"/a/b/ca\",\"/a/b/d\"]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.RemoveSubfolders(input.ParseStringArray());
        var expected = output.ParseStringArray().OrderBy(x => x.Length).ToArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}