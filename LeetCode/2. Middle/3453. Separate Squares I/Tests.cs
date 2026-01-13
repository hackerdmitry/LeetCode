using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3453._Separate_Squares_I;

[TestFixture(TestName = "3453. Separate Squares I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[522261215,954313664,225462],[628661372,718610752,10667],[619734768,941310679,44788],[352367502,656774918,289036],[860247066,905800565,100123],[817623994,962847576,71460],[691552058,782740602,36271],[911356,152015365,513881],[462847044,859151855,233567],[672324240,954509294,685569]]", 954521423.80202)]
    [TestCase("[[0,0,2],[1,1,1]]", 1.16667)]
    [TestCase("[[0,0,3]]", 1.5)]
    [TestCase("[[0,0,1],[2,2,1]]", 1.00000)]
    [TestCase("[[0,0,1],[0,10,1],[0,10,1]]", 10.25)]
    public void Test(string input, double output)
    {
        var solution = new Solution();
        var actual = solution.SeparateSquares(input.ParseIntArray2d());
        Assert.AreEqual(output, actual, 10e-5);
    }
}
