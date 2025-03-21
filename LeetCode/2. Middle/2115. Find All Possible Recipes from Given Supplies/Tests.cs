using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2115._Find_All_Possible_Recipes_from_Given_Supplies;

[TestFixture(TestName = "2115. Find All Possible Recipes from Given Supplies")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"bread\"]", "[[\"yeast\",\"flour\"]]", "[\"yeast\",\"flour\",\"corn\"]", "[\"bread\"]")]
    [TestCase("[\"x\"]","[\"x\",\"a\"]","[\"a\"]","[]")]
    [TestCase("[\"ju\",\"fzjnm\",\"x\",\"e\",\"zpmcz\",\"h\",\"q\"]", "[[\"d\"],[\"hveml\",\"f\",\"cpivl\"],[\"cpivl\",\"zpmcz\",\"h\",\"e\",\"fzjnm\",\"ju\"],[\"cpivl\",\"hveml\",\"zpmcz\",\"ju\",\"h\"],[\"h\",\"fzjnm\",\"e\",\"q\",\"x\"],[\"d\",\"hveml\",\"cpivl\",\"q\",\"zpmcz\",\"ju\",\"e\",\"x\"],[\"f\",\"hveml\",\"cpivl\"]]", "[\"f\",\"hveml\",\"cpivl\",\"d\"]", "[\"ju\",\"fzjnm\",\"x\",\"e\",\"zpmcz\",\"h\",\"q\"]")]
    [TestCase("[\"bread\",\"sandwich\"]", "[[\"yeast\",\"flour\"],[\"bread\",\"meat\"]]", "[\"yeast\",\"flour\",\"meat\"]", "[\"bread\",\"sandwich\"]")]
    [TestCase("[\"bread\"]", "[[\"yeast\",\"flour\"]]", "[\"yeast\"]", "[]")]
    [TestCase("[\"bread\",\"sandwich\",\"burger\"]", "[[\"yeast\",\"flour\"],[\"bread\",\"meat\"],[\"sandwich\",\"meat\",\"bread\"]]", "[\"yeast\",\"flour\",\"meat\"]", "[\"bread\",\"sandwich\",\"burger\"]")]
    public void Test(string input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.FindAllRecipes(input1.ParseStringArray(), input2.ParseStringArray2d(), input3.ParseStringArray());
        var expected = output.ParseStringArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
