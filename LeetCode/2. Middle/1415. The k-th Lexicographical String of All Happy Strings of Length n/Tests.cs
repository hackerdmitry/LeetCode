using NUnit.Framework;

namespace LeetCode._2._Middle._1415._The_k_th_Lexicographical_String_of_All_Happy_Strings_of_Length_n;

[TestFixture(TestName = "1415. The k-th Lexicographical String of All Happy Strings of Length n")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(10, 100, "abacbabacb")]
    [TestCase(1, 3, "c")]
    [TestCase(1, 4, "")]
    [TestCase(3, 9, "cab")]
    public void Test(int input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.GetHappyString(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
