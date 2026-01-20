using NUnit.Framework;

namespace LeetCode._1._Easy._28._Find_the_Index_of_the_First_Occurrence_in_a_String;

[TestFixture(TestName = "28. Find the Index of the First Occurrence in a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("sadbutsad", "sad", 0)]
    [TestCase("leetcode", "leeto", -1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.StrStr(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
