using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._3307._Find_the_K_th_Character_in_String_Game_II;

[TestFixture(TestName = "3307. Find the K-th Character in String Game II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(12145134613, "[0,0,0,0,1,0,0,0,1,1,1,1,1,0,1,0,0,0,1,0,0,0,0,0,1,1,0,1,0,0,1,1,1,1,1]", 'i')]
    [TestCase(5, "[0,0,0]", 'a')]
    [TestCase(10, "[0,1,0,1]", 'b')]
    [TestCase(10, "[1,1,1,1]", 'c')]
    [TestCase(16, "[1,1,1,1]", 'e')]
    [TestCase(12, "[1,1,1,1]", 'd')]
    [TestCase(13, "[1,1,1,1]", 'c')]
    public void Test(long input1, string input2, char output)
    {
        var solution = new Solution();
        var actual = solution.KthCharacter(input1, input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
