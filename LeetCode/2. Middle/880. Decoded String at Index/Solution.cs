using System.Collections.Generic;

namespace LeetCode._2._Middle._880._Decoded_String_at_Index
{
    public class Solution
    {
        public string DecodeAtIndex(string s, int k)
        {
            var words = new List<(string Word, int Digit, int Repeat, long Sum)>();

            var lastDigitPos = -1;
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (char.IsDigit(c))
                {
                    var digit = c - '0';
                    var startIndex = lastDigitPos + 1;
                    var length = i - lastDigitPos - 1;
                    lastDigitPos = i;
                    AddWord(s, startIndex, length, words, digit);
                    if (words[^1].Sum >= int.MaxValue)
                        break;
                }
            }

            if (lastDigitPos != s.Length - 1 && words.Count == 0 || words[^1].Sum < int.MaxValue)
            {
                var startIndex = lastDigitPos + 1;
                var length = s.Length - lastDigitPos - 1;
                AddWord(s, startIndex, length, words, 1);
            }

            k--;
            while (true)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    var word = words[i];
                    if (k < word.Sum)
                    {
                        k %= word.Repeat;

                        if (i == 0 || k >= words[i - 1].Sum)
                        {
                            if (i > 0)
                                k -= (int) words[i - 1].Sum;
                            return word.Word[k % word.Word.Length].ToString();
                        }

                        break;
                    }
                }
            }
        }

        private static void AddWord(
            string s, int startIndex, int length,
            List<(string Word, int Digit, int Repeat, long Sum)> words, int digit)
        {
            var word = s.Substring(startIndex, length);

            if (word.Length == 0)
            {
                words[^1] = (
                    words[^1].Word,
                    words[^1].Digit,
                    words[^1].Repeat,
                    words[^1].Sum * digit);
                return;
            }

            var prevSum = words.Count == 0 ? 0 : words[^1].Sum;
            var repeat = prevSum + word.Length;
            var sum = repeat * digit;
            words.Add((word, digit, (int) repeat, sum));
        }
    }
}