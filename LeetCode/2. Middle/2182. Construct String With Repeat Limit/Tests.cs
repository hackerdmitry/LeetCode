using NUnit.Framework;

namespace LeetCode._2._Middle._2182._Construct_String_With_Repeat_Limit;

[TestFixture(TestName = "2182. Construct String With Repeat Limit")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("xyutfpopdynbadwtvmxiemmusevduloxwvpkjioizvanetecnuqbqqdtrwrkgt", 1, "zyxyxwxwvwvuvuvututstrtrtqpqpqponononmlmkmkjigifiededededcbaba")]
    [TestCase("cczazcc", 3, "zzcccac")]
    [TestCase("aababab", 2, "bbabaa")]
    [TestCase("ccc", 1, "c")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RepeatLimitedString(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
