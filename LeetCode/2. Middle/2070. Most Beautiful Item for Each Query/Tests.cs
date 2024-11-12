using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2070._Most_Beautiful_Item_for_Each_Query;

[TestFixture(TestName = "2070. Most Beautiful Item for Each Query")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[193,732],[781,962],[864,954],[749,627],[136,746],[478,548],[640,908],[210,799],[567,715],[914,388],[487,853],[533,554],[247,919],[958,150],[193,523],[176,656],[395,469],[763,821],[542,946],[701,676]]", "[885,1445,1580,1309,205,1788,1214,1404,572,1170,989,265,153,151,1479,1180,875,276,1584]", "[962,962,962,962,746,962,962,962,946,962,962,919,746,746,962,962,962,919,962]")]
    [TestCase("[[1,2],[3,2],[2,4],[5,6],[3,5]]", "[1,2,3,4,5,6]", "[2,4,5,5,6,6]")]
    [TestCase("[[1,2],[1,2],[1,3],[1,4]]", "[1]", "[4]")]
    [TestCase("[[10,1000]]", "[5]", "[0]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.MaximumBeauty(input1.ParseIntArray2d(), input2.ParseIntArray());
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}