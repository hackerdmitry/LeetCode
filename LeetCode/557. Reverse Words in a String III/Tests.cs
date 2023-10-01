using NUnit.Framework;

namespace LeetCode._557._Reverse_Words_in_a_String_III
{
    [TestFixture(TestName = "557. Reverse Words in a String III")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
        [TestCase("God Ding", "doG gniD")]
        public void Test(string input, string output)
        {
            var solution = new Solution();
            var actual = solution.ReverseWords(input);
            Assert.AreEqual(output, actual);
        }
    }
}