using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3._Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;

        var queue = new Queue<char>();
        var hashSet = new HashSet<char>();
        foreach (var letter in s)
        {
            if (hashSet.Add(letter))
            {
                queue.Enqueue(letter);
                maxLength = Math.Max(maxLength, queue.Count);
            }
            else
            {
                while (true)
                {
                    var oldLetter = queue.Dequeue();
                    hashSet.Remove(oldLetter);
                    if (oldLetter == letter)
                        break;
                }

                queue.Enqueue(letter);
                hashSet.Add(letter);
            }
        }

        return maxLength;
    }
}