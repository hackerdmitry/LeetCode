using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._350._Intersection_of_Two_Arrays_II;

[TestFixture(TestName = "350. Intersection of Two Arrays II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,2,1]", "[2,2]", "[2,2]")]
    [TestCase("[4,9,5]", "[9,4,9,8,4]", "[4,9]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.Intersect(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
