using NUnit.Framework;

namespace LeetCode._1._Easy._844._Backspace_String_Compare
{
    [TestFixture(TestName = "844. Backspace String Compare")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase("ab#c", "ad#c", true)]
        [TestCase("ad#c", "ab#c", true)]
        [TestCase("ab##", "c#d#", true)]
        [TestCase("a#c", "b", false)]
        [TestCase("a##c", "#a#c", true)]
        [TestCase("bxj##tw", "bxo#j##tw", true)]
        [TestCase("bxj##tw", "bxj###tw", false)]
        [TestCase("nzp#o#g", "b#nzp#o#g", true)]
        [TestCase("nzp#o#g", "ииnzp#o#g", false)]
        public void Test(string input1, string input2, bool output)
        {
            var solution = new Solution();
            var actual = solution.BackspaceCompare(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}