using NUnit.Framework;

namespace LeetCode._2._Middle._2336._Smallest_Number_in_Infinite_Set;

[TestFixture(TestName = "2336. Smallest Number in Infinite Set")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 2, 3)]
    public void Test(int input1, int input2, int output)
    {
        var smallestInfiniteSet = new SmallestInfiniteSet();
        smallestInfiniteSet.AddBack(2);
        Assert.AreEqual(1, smallestInfiniteSet.PopSmallest());
        Assert.AreEqual(2, smallestInfiniteSet.PopSmallest());
        Assert.AreEqual(3, smallestInfiniteSet.PopSmallest());
        smallestInfiniteSet.AddBack(1);
        Assert.AreEqual(1, smallestInfiniteSet.PopSmallest());
        Assert.AreEqual(4, smallestInfiniteSet.PopSmallest());
        Assert.AreEqual(5, smallestInfiniteSet.PopSmallest());
    }
}
