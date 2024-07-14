using NUnit.Framework;

namespace LeetCode._3._Hard._726._Number_of_Atoms;

[TestFixture(TestName = "726. Number of Atoms")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("H2O", "H2O")]
    [TestCase("Mg(OH)2", "H2MgO2")]
    [TestCase("K4(ON(SO3)2)2", "K4N2O14S4")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.CountOfAtoms(input);
        Assert.AreEqual(output, actual);
    }
}