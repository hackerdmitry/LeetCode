using NUnit.Framework;

namespace LeetCode._3._Hard._1931._Painting_a_Grid_With_Three_Different_Colors;

[TestFixture(TestName = "1931. Painting a Grid With Three Different Colors")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 2, 18)]
    [TestCase(2, 37, 478020091)]
    [TestCase(1, 1, 3)]
    [TestCase(1, 2, 6)]
    [TestCase(5, 5, 580986)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.ColorTheGrid(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
