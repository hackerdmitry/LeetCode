using NUnit.Framework;

namespace LeetCode._2._Middle._3815._Design_Auction_System;

[TestFixture(TestName = "3815. Design Auction System")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test1()
    {
        var auctionSystem = new AuctionSystem();
        auctionSystem.AddBid(1, 7, 5);
        auctionSystem.AddBid(2, 7, 6);
        Assert.AreEqual(2, auctionSystem.GetHighestBidder(7));
        auctionSystem.UpdateBid(1, 7, 8);
        Assert.AreEqual(1, auctionSystem.GetHighestBidder(7));
        auctionSystem.RemoveBid(2, 7);
        Assert.AreEqual(1, auctionSystem.GetHighestBidder(7));
        Assert.AreEqual(-1, auctionSystem.GetHighestBidder(3));
    }
    [Test]
    public void Test2()
    {
        var auctionSystem = new AuctionSystem();
        auctionSystem.AddBid(10,1,1000);
        auctionSystem.AddBid(20,1,1000);
        Assert.AreEqual(20, auctionSystem.GetHighestBidder(1));
    }
}