using NUnit.Framework;

namespace LeetCode._2._Middle._2337._Move_Pieces_to_Obtain_a_String;

[TestFixture(TestName = "2337. Move Pieces to Obtain a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("LLRR", "LLRR", true)]
    [TestCase("_R", "L_", false)]
    [TestCase("_L__R__R_", "L______RR", true)]
    [TestCase("R_L_", "__LR", false)]
    [TestCase("_R", "R_", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanChange(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
