using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3829._Design_Ride_Sharing_System;

[TestFixture(TestName = "3829. Design Ride Sharing System")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test1()
    {
        var rideSharingSystem = new RideSharingSystem();
        rideSharingSystem.AddRider(3);
        rideSharingSystem.AddDriver(2);
        rideSharingSystem.AddRider(1);
        Assert.AreEqual("[2, 3]".ParseIntArray(), rideSharingSystem.MatchDriverWithRider());
        rideSharingSystem.AddDriver(5);
        rideSharingSystem.CancelRider(3);
        Assert.AreEqual("[5, 1]".ParseIntArray(), rideSharingSystem.MatchDriverWithRider());
        Assert.AreEqual("[-1, -1]".ParseIntArray(), rideSharingSystem.MatchDriverWithRider());
    }

    [Timeout(1000)]
    [Test]
    public void Test2()
    {
        var rideSharingSystem = new RideSharingSystem();
        rideSharingSystem.AddRider(8);
        rideSharingSystem.AddDriver(8);
        rideSharingSystem.AddDriver(6);
        Assert.AreEqual("[8, 8]".ParseIntArray(), rideSharingSystem.MatchDriverWithRider());
        rideSharingSystem.AddRider(2);
        rideSharingSystem.CancelRider(2);
        Assert.AreEqual("[-1, -1]".ParseIntArray(), rideSharingSystem.MatchDriverWithRider());
    }
}
