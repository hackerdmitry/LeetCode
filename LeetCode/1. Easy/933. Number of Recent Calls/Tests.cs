using NUnit.Framework;

namespace LeetCode._1._Easy._933._Number_of_Recent_Calls;

[TestFixture(TestName = "933. Number of Recent Calls")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test()
    {
        var recentCounter = new RecentCounter();
        Assert.AreEqual(recentCounter.Ping(1), 1);
        Assert.AreEqual(recentCounter.Ping(100), 2);
        Assert.AreEqual(recentCounter.Ping(3001), 3);
        Assert.AreEqual(recentCounter.Ping(3002), 3);
    }
}
