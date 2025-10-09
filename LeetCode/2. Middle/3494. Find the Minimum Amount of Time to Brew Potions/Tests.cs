using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3494._Find_the_Minimum_Amount_of_Time_to_Brew_Potions;

[TestFixture(TestName = "3494. Find the Minimum Amount of Time to Brew Potions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,5,3,9]", "[1,10,7,3]", 293)]
    [TestCase("[2,8,8,6]", "[8,7,10,3]", 382)]
    [TestCase("[1,5,2,4]", "[5,1,4,2]", 110)]
    [TestCase("[1,1,1]", "[1,1,1]", 5)]
    [TestCase("[1,2,3,4]", "[1,2]", 21)]
    [TestCase("[1539,3208,2653,1697,2885,4065,1984,3356,3223,1056,13,4960,4728,2356,4012,553,1601,2356,1377,1932,1101,1802,2621,4023,507,4165,3048,4676,1012,737,2573,3417,4503,3729,956,1175,2282,1868,4974,2570,1980,2301,3148,1436,3662,4212,1951]", "[3271,1584,466,4543,2483,651,2281,2739,534,1729,4646,3573,2544,2743,4728,4888,3411,2519,3358,185,1547,1114,2557,618,342,2904]", 2766933798)]
    public void Test(string input1, string input2, long output)
    {
        var solution = new Solution();
        var actual = solution.MinTime(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
