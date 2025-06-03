using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1298._Maximum_Candies_You_Can_Get_from_Boxes;

[TestFixture(TestName = "1298. Maximum Candies You Can Get from Boxes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,1,0]", "[7,5,4,100]", "[[],[],[1],[]]", "[[1,2],[3],[],[]]", "[0]", 16)]
    [TestCase("[1,0,0,0,0,0]", "[1,1,1,1,1,1]", "[[1,2,3,4,5],[],[],[],[],[]]", "[[1,2,3,4,5],[],[],[],[],[]]", "[0]", 6)]
    public void Test(string input1, string input2, string input3, string input4, string input5, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxCandies(input1.ParseIntArray(), input2.ParseIntArray(), input3.ParseIntArray2d(), input4.ParseIntArray2d(), input5.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
