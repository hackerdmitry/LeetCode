using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2097._Valid_Arrangement_of_Pairs;

[TestFixture(TestName = "2097. Valid Arrangement of Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,3],[1,2],[2,1]]")]
    [TestCase("[[8,5],[8,7],[0,8],[0,5],[7,0],[5,0],[0,7],[8,0],[7,8]]")]
    [TestCase("[[5,1],[4,5],[11,9],[9,4]]")]
    [TestCase("[[1,3],[3,2],[2,1]]")]
    [TestCase("[[1,2],[1,3],[2,1]]")]
    [TestCase("[[1,2],[2,1],[1,3],[2,3],[3,2]")]
    public void Test(string input)
    {
        var solution = new Solution();
        var pairs = input.ParseIntArray2d();

        var actual = solution.ValidArrangement(pairs);
        actual.WriteLine("actual");

        Assert.AreEqual(pairs.Length, actual.Length);
        foreach (var pair in actual)
            Assert.NotNull(pair);
        for (var i = 1; i < actual.Length; i++)
            Assert.AreEqual(actual[i - 1][1], actual[i][0]);

        using var enumerator1 = pairs.OrderBy(x => x[0]).ThenBy(x => x[1]).GetEnumerator();
        using var enumerator2 = actual.OrderBy(x => x[0]).ThenBy(x => x[1]).GetEnumerator();

        while (enumerator1.MoveNext() && enumerator2.MoveNext())
            Assert.AreEqual(enumerator1.Current!, enumerator2.Current!);
    }
}