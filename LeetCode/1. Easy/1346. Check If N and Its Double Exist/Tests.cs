using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1346._Check_If_N_and_Its_Double_Exist;

[TestFixture(TestName = "1346. Check If N and Its Double Exist")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-10,12,-20,-8,15]", true)]
    [TestCase("[-2,0,10,-19,4,6,-8]", false)]
    [TestCase("[10,2,5,3]", true)]
    [TestCase("[0,0]", true)]
    [TestCase("[3,1,7,11]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CheckIfExist(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}