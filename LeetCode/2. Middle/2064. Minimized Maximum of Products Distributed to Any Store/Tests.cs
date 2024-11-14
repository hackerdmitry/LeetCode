using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2064._Minimized_Maximum_of_Products_Distributed_to_Any_Store;

[TestFixture(TestName = "2064. Minimized Maximum of Products Distributed to Any Store")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(99955, "[599,160,730,649,695,810,788,486,643,855,802,373,95,802,664,878,588,433,160,715,290,482,37,503,703,255,533,641,153,165,516,436,349,414,420,257,617,37,298,715,63765,388,925,380,402,861,850,10651,585,417,401,199,689,636,997,18,22310,470,816,34,72630,131,654,347,299,516,24,296,608,279,839,762,510,710,477,411,775,545,62,958,73]", 3)]
    [TestCase(7, "[15,10,10]", 5)]
    [TestCase(6, "[11,7]", 4)]
    [TestCase(6, "[11,6]", 3)]
    [TestCase(3, "[2,10,6]", 10)]
    [TestCase(1, "[100000]", 100000)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimizedMaximum(input1, input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
