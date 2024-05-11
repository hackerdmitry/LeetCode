using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._17._Letter_Combinations_of_a_Phone_Number;

public class Solution
{
    private static readonly Dictionary<char, char[]> numbers = new()
    {
        {'2', new[] {'a', 'b', 'c'}},
        {'3', new[] {'d', 'e', 'f'}},
        {'4', new[] {'g', 'h', 'i'}},
        {'5', new[] {'j', 'k', 'l'}},
        {'6', new[] {'m', 'n', 'o'}},
        {'7', new[] {'p', 'q', 'r', 's'}},
        {'8', new[] {'t', 'u', 'v'}},
        {'9', new[] {'w', 'x', 'y', 'z'}},
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (digits == string.Empty)
            return Array.Empty<string>();

        var resultLenght = digits.Aggregate(1, (resMult, digit) => numbers[digit].Length * resMult);
        var result = new string[resultLenght];
        var indexResult = 0;

        var queue = new Queue<string>(numbers[digits[0]].Select(x => x.ToString()));
        while (queue.Count > 0)
        {
            var word = queue.Dequeue();
            if (word.Length == digits.Length)
                result[indexResult++] = word;
            else
                foreach (var letter in numbers[digits[word.Length]])
                    queue.Enqueue(word + letter);
        }

        return result;
    }
}