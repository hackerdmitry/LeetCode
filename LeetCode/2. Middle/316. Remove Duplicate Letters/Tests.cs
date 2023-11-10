using NUnit.Framework;

namespace LeetCode._2._Middle._316._Remove_Duplicate_Letters
{
    [TestFixture(TestName = "316. Remove Duplicate Letters")]
    public class Tests
    {
        [TestCase("a", "a")]
        [TestCase("ba", "ba")]
        [TestCase("bcabc", "abc")]
        [TestCase("cbacdcbc", "acdb")]
        [TestCase("ecbacba", "eacb")]
        [TestCase("abcbcd", "abcd")]
        [TestCase("acbcbd", "abcd")]
        [TestCase("acdbcd", "abcd")]
        [TestCase("cdbcd", "bcd")]
        // ------------b-feg---k-uyj---orn-d----i-qszp--c---a--w-
        // --------0---------1---------2---------3---------4----- <- 45
        [TestCase("rusrbofeggbbkyuyjsrzornpdguwzizqszpbicdquakqws", "bfegkuyjorndiqszpcaw")]
        [TestCase("acdebcde", "abcde")]
        [TestCase("acdebcde", "abcde")]
        [TestCase("acdebced", "abced")]
        public void Test(string input, string output)
        {
            var solution = new Solution();
            var actual = solution.RemoveDuplicateLetters(input);
            Assert.AreEqual(output, actual);
        }
    }
}