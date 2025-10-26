using NUnit.Framework;

namespace LeetCode._2._Middle._2043._Simple_Bank_System;

[TestFixture(TestName = "2043. Simple Bank System")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test1()
    {
        var bank = new Bank(new long[] {10, 100, 20, 50, 30});
        Assert.True(bank.Withdraw(3, 10));
        Assert.True(bank.Transfer(5, 1, 20));
        Assert.True(bank.Deposit(5, 20));
        Assert.False(bank.Transfer(3, 4, 15));
        Assert.False(bank.Withdraw(10, 50));
    }
}