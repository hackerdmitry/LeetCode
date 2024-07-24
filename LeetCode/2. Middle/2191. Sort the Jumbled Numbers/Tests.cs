using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2191._Sort_the_Jumbled_Numbers;

[TestFixture(TestName = "2191. Sort the Jumbled Numbers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[8,9,4,0,2,1,3,5,7,6]", "[991,338,38]", "[338,38,991]")]
    [TestCase("[0,1,2,3,4,5,6,7,8,9]", "[789,456,123]", "[123,456,789]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.SortJumbled(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
