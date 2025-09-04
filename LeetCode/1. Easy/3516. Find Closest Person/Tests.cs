using NUnit.Framework;

namespace LeetCode._1._Easy._3516._Find_Closest_Person;

[TestFixture(TestName = "3516. Find Closest Person")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 7, 4, 1)]
    [TestCase(2, 5, 6, 2)]
    [TestCase(1, 5, 3, 0)]
    public void Test(int input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.FindClosest(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}
