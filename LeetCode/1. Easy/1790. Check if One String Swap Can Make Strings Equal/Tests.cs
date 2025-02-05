using NUnit.Framework;

namespace LeetCode._1._Easy._1790._Check_if_One_String_Swap_Can_Make_Strings_Equal;

[TestFixture(TestName = "1790. Check if One String Swap Can Make Strings Equal")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("bank", "kanb", true)]
    [TestCase("aank", "kanb", false)]
    [TestCase("bbnk", "kanb", false)]
    [TestCase("attack", "defend", false)]
    [TestCase("kelb", "kelb", true)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.AreAlmostEqual(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
