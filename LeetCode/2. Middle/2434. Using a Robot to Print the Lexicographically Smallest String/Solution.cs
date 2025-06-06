using System.Collections.Generic;

namespace LeetCode._2._Middle._2434._Using_a_Robot_to_Print_the_Lexicographically_Smallest_String;

public class Solution
{
    public string RobotWithString(string s)
    {
        var sLetters = new int[26];
        var sQueue = new Queue<char>(s.Length);
        foreach (var c in s)
        {
            sQueue.Enqueue(c);
            sLetters[c - 'a']++;
        }
        var tStack = new Stack<char>();
        return Solve(sQueue, sLetters, tStack);
    }

    private string Solve(Queue<char> sQueue, int[] sLetters, Stack<char> tStack)
    {
        var result = new char[sQueue.Count];
        var resultIndex = 0;

        while (resultIndex < result.Length)
        {
            if (sQueue.Count == 0)
            {
                result[resultIndex++] = tStack.Pop();
                continue;
            }

            var minLetter = GetMinLetter(sLetters);
            if (tStack.Count == 0 || tStack.Peek() > minLetter)
            {
                FindMinLetter(sQueue, sLetters, tStack, minLetter);
                result[resultIndex++] = minLetter;
                continue;
            }

            result[resultIndex++] = tStack.Pop();
        }

        return new string(result);
    }

    private static void FindMinLetter(Queue<char> sQueue, int[] sLetters, Stack<char> tStack, char minLetter)
    {
        while (true)
        {
            var letter = sQueue.Dequeue();
            sLetters[letter - 'a']--;

            if (letter == minLetter)
                return;

            tStack.Push(letter);
        }
    }

    private char GetMinLetter(int[] sLetters)
    {
        for (var i = 0; i < 26; i++)
            if (sLetters[i] > 0)
                return (char) (i + 'a');
        return char.MinValue;
    }
}
