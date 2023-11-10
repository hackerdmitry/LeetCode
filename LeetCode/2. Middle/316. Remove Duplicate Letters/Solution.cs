using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._2._Middle._316._Remove_Duplicate_Letters
{
    public class Solution
    {
        public string RemoveDuplicateLetters(string s)
        {
            var input = s;

            var letterPositions = input
                .Select((x, i) => (x, i))
                .GroupBy(x => x.x, x => x.i)
                .OrderBy(x => x.Key)
                .ToDictionary(
                    x => x.Key,
                    x => x.Select(y => y).ToArray()
                );
            var keys = letterPositions.Keys.ToArray();

            return GetMinimalLex(
                input.ToArray(),
                keys,
                letterPositions
            );
        }

        private string GetMinimalLex(char[] word, char[] letters, Dictionary<char, int[]> letterPositions)
        {
            var letterLastPositions = new Dictionary<char, int>(letters.Length);

            var position = word.Length - 1;
            foreach (var letter in word.Reverse())
            {
                letterLastPositions.TryAdd(letter, position--);
            }

            var linkWord = new LinkedList<char>();
            var leftLetters = letters.ToHashSet();

            var lastPos = -1;
            while (leftLetters.Count > 0)
            {
                foreach (var letter in letters)
                {
                    if (leftLetters.Contains(letter))
                    {
                        var firstLetterPosition = letterPositions[letter].First(x => x > lastPos);
                        if (leftLetters.All(x => letterLastPositions[x] >= firstLetterPosition))
                        {
                            linkWord.AddLast(letter);
                            leftLetters.Remove(letter);
                            lastPos = firstLetterPosition;
                            break;
                        }
                    }
                }
            }

            var sb = new StringBuilder();
            foreach (var c in linkWord)
                sb.Append(c);
            return sb.ToString();
        }
    }
}