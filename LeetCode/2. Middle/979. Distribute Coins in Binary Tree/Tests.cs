using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._979._Distribute_Coins_in_Binary_Tree;

[TestFixture(TestName = "979. Distribute Coins in Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,0,0]", 2)]
    [TestCase("[0,3,0]", 3)]
    [TestCase("[0,2,3,0,0,null,null,1]", 5)]
    [TestCase("[0,1,2,null,2,2,0,null,null,null,null,null,0]", 6)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.DistributeCoins(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}