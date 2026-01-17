using NUnit.Framework;

namespace LeetCode._2._Middle._901._Online_Stock_Span;

[TestFixture(TestName = "901. Online Stock Span")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test()
    {
        var stockSpanner = new StockSpanner();
        Assert.AreEqual(1, stockSpanner.Next(100));
        Assert.AreEqual(1, stockSpanner.Next(80));
        Assert.AreEqual(1, stockSpanner.Next(60));
        Assert.AreEqual(2, stockSpanner.Next(70));
        Assert.AreEqual(1, stockSpanner.Next(60));
        Assert.AreEqual(4, stockSpanner.Next(75));
        Assert.AreEqual(6, stockSpanner.Next(85));
    }
}
