using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1437._Check_If_All_1_s_Are_at_Least_Length_K_Places_Away;

[TestFixture(TestName = "1437. Check If All 1's Are at Least Length K Places Away")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,0,0,1,0,0,1]", 2, true)]
    [TestCase("[1,0,0,1,0,1]", 2, false)]
    public void Test(string input1, int input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.KLengthApart(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
