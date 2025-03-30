using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._763._Partition_Labels;

[TestFixture(TestName = "763. Partition Labels")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("ababcbacadefegdehijhklij", "[9,7,8]")]
    [TestCase("eccbbbbdec", "[10]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.PartitionLabels(input);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
