using NUnit.Framework;

namespace LeetCode._1._Easy._3304._Find_the_K_th_Character_in_String_Game_I;

[TestFixture(TestName = "3304. Find the K-th Character in String Game I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, 'b')]
    [TestCase(10, 'c')]
    public void Test(int input, char output)
    {
        var solution = new Solution();
        var actual = solution.KthCharacter(input);
        Assert.AreEqual(output, actual);
    }
}
