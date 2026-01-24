using System.Linq;

namespace LeetCode._1._Easy._383._Ransom_Note;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteArr = CreateLettersArray(ransomNote);
        var magazineArr = CreateLettersArray(magazine);
        return Enumerable.Range(0, 26).All(i => magazineArr[i] >= ransomNoteArr[i]);
    }

    private int[] CreateLettersArray(string str)
    {
        var letterArr = new int[26];
        foreach (var c in str)
            letterArr[c - 'a']++;
        return letterArr;
    }
}