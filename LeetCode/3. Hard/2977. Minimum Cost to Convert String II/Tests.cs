using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._2977._Minimum_Cost_to_Convert_String_II;

[TestFixture(TestName = "2977. Minimum Cost to Convert String II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("jpyjj","jqnfp","[\"j\",\"i\",\"q\",\"u\",\"y\",\"w\",\"d\",\"a\",\"h\",\"s\",\"i\",\"y\",\"w\",\"pyj\",\"qng\",\"lrn\",\"nrm\",\"tvn\",\"fei\",\"fpj\",\"qlw\",\"lrb\",\"ufu\",\"kll\",\"nqp\"]","[\"i\",\"q\",\"u\",\"y\",\"w\",\"d\",\"a\",\"h\",\"s\",\"i\",\"y\",\"w\",\"p\",\"qng\",\"lrn\",\"nrm\",\"tvn\",\"fei\",\"fpj\",\"qlw\",\"lrb\",\"ufu\",\"kll\",\"nqp\",\"qnf\"]","[62657,90954,55348,88767,87756,55487,49700,51801,94877,81661,99027,91814,62872,25235,62153,96875,12009,85321,68993,75866,72888,96411,78568,83975,60456]",1131062)]
    [TestCase("bavusatavvvuubavsauavubtusubsvtsvsbttbvs", "ssauttbvssatusutusbattuttsutabubutuasvuu", "[\"b\",\"a\",\"v\",\"s\",\"t\",\"a\",\"v\",\"a\",\"v\",\"s\",\"u\",\"u\",\"b\",\"s\",\"v\",\"t\",\"s\",\"b\",\"t\",\"b\"]", "[\"s\",\"s\",\"a\",\"t\",\"b\",\"v\",\"s\",\"u\",\"t\",\"u\",\"b\",\"t\",\"t\",\"a\",\"b\",\"u\",\"b\",\"u\",\"a\",\"v\"]", "[948,467,690,969,300,877,924,924,791,724,809,652,388,592,772,829,912,679,751,529]", 27579)]
    [TestCase("abcd", "acbe", "[\"a\",\"b\",\"c\",\"c\",\"e\",\"d\"]", "[\"b\",\"c\",\"b\",\"e\",\"b\",\"e\"]", "[2,5,5,1,2,20]", 28)]
    [TestCase("abcdefgh", "acdeeghh", "[\"bcd\",\"fgh\",\"thh\"]", "[\"cde\",\"thh\",\"ghh\"]", "[1,3,5]", 9)]
    [TestCase("abcdefgh", "addddddd", "[\"bcd\",\"defgh\"]", "[\"ddd\",\"ddddd\"]", "[100,1578]", -1)]
    public void Test(string input1, string input2, string input3, string input4, string input5, long output)
    {
        var solution = new Solution();
        var actual = solution.MinimumCost(input1, input2, input3.ParseStringArray(), input4.ParseStringArray(), input5.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split('\n');
        Test(inputs[0], inputs[1], inputs[2], inputs[3], inputs[4], output.ParseLong());
    }
}
