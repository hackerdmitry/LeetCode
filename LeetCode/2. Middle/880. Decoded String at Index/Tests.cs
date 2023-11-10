using NUnit.Framework;

namespace LeetCode._880._Decoded_String_at_Index
{
    [TestFixture(TestName = "880. Decoded String at Index")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase("leet2code3", 10, "o")]
        [TestCase("ha22", 5, "h")]
        [TestCase("a2345678999999999999999", 1, "a")]
        [TestCase("leet2code3", 29, "l")]
        [TestCase("leet2code3", 24, "e")]
        [TestCase("leet2code3", 23, "d")]
        [TestCase("a1b2c3", 15, "c")]
        [TestCase("a1b2c3", 12, "b")]
        [TestCase("abc", 1, "a")]
        [TestCase("abc", 3, "c")]
        [TestCase("a2c", 3, "c")]
        [TestCase("a4vsb832i3zxouzx6vu6", 31179, "b")]
        [TestCase("a4vsb832i3zxouzx6vu6", 1, "a")]
        [TestCase("a4vsb832i3zxouzx6vu6", 5, "v")]
        [TestCase("a4vsb832i3zxouzx6vu6", 337, "i")]
        [TestCase("a4vsb832i3zxouzx6vu6", 1012, "z")]
        [TestCase("a4vsb832i3zxouzx6vu6", 6103, "v")]
        [TestCase("a4vsb832i3zxouzx6vu6", 36624, "u")]
        public void Test(string input1, int input2, string output)
        {
            var solution = new Solution();
            var actual = solution.DecodeAtIndex(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}