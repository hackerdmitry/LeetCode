using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._135._Candy;

[TestFixture(TestName = "135. Candy")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,4,5,2]", 11)]
    [TestCase("[1,2,87,87,87,2,1]", 13)]
    [TestCase("[29,51,87,87,72,12]", 12)]
    [TestCase("[1,0,2]", 5)]
    [TestCase("[1,2,2]", 4)]
    [TestCase("[1,3,2,2,1]", 7)]
    [TestCase("[0,1,2,3,4,5,0]", 22)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.Candy(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
