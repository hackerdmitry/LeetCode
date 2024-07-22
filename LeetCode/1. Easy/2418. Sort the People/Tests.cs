using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2418._Sort_the_People;

[TestFixture(TestName = "2418. Sort the People")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"Mary\",\"John\",\"Emma\"]", "[180,165,170]", "[\"Mary\",\"Emma\",\"John\"]")]
    [TestCase("[\"Alice\",\"Bob\",\"Bob\"]", "[155,185,150]", "[\"Bob\",\"Alice\",\"Bob\"]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.SortPeople(input1.ParseStringArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
