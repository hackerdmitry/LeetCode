using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1339._Maximum_Product_of_Splitted_Binary_Tree;

[TestFixture(TestName = "1339. Maximum Product of Splitted Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5,6]", 110)]
    [TestCase("[1,null,2,3,4,null,null,5,6]", 90)]
    [TestCase("[2,2]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProduct(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
