using System.Collections.Generic;

namespace LeetCode._2._Middle._1079._Letter_Tile_Possibilities;

public class Solution
{
    public int NumTilePossibilities(string tiles)
    {
        var letters = CreateLetters(tiles);
        return RecursiveCombinations(letters, 1, tiles.Length);
    }

    private Dictionary<char, int> CreateLetters(string tiles)
    {
        var letters = new Dictionary<char, int>();
        foreach (var tile in tiles)
            if (!letters.TryAdd(tile, 1))
                letters[tile]++;
        return letters;
    }

    private int RecursiveCombinations(Dictionary<char, int> letters, int currentLength, int maxLength)
    {
        var result = 0;
        foreach (var (letter, count) in letters)
            if (count > 0)
            {
                letters[letter]--;
                result++;
                if (currentLength < maxLength)
                    result += RecursiveCombinations(letters, currentLength + 1, maxLength);
                letters[letter]++;
            }

        return result;
    }
}
