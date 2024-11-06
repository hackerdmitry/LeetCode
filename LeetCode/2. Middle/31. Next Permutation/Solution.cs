using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._31._Next_Permutation;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length == 1)
            return;

        if (nums[^2] < nums[^1])
        {
            (nums[^2], nums[^1]) = (nums[^1], nums[^2]);
            return;
        }

        var numbersBag = new Dictionary<int, int>();
        AddNumber(numbersBag, nums[^1]);
        for (var i = nums.Length - 1; i > 0; i--)
            if (nums[i - 1] >= nums[i])
                AddNumber(numbersBag, nums[i - 1]);
            else
                break;

        var countNumbers = CountNumbers(numbersBag);
        if (countNumbers != nums.Length)
        {
            var indexCandidate = nums.Length - countNumbers - 1;
            var numberCandidate = nums[indexCandidate];
            nums[indexCandidate] = numbersBag.Select(x => x.Key).Where(x => x > numberCandidate).Min();
            RemoveNumber(numbersBag, nums[indexCandidate]);
            AddNumber(numbersBag, numberCandidate);
        }

        using var orderedNumbersEnumerator = numbersBag.SelectMany(FlatNumbers).OrderBy(x => x).GetEnumerator();
        for (var i = nums.Length - countNumbers; orderedNumbersEnumerator.MoveNext(); i++)
            nums[i] = orderedNumbersEnumerator.Current;
    }

    private void AddNumber(Dictionary<int, int> numbersBag, int number)
    {
        if (!numbersBag.TryAdd(number, 1))
            numbersBag[number]++;
    }

    private void RemoveNumber(Dictionary<int, int> numbersBag, int number)
    {
        numbersBag[number]--;
        if (numbersBag[number] == 0)
            numbersBag.Remove(number);
    }

    private int CountNumbers(Dictionary<int, int> numbersBag)
    {
        return numbersBag.Sum(x => x.Value);
    }

    private IEnumerable<int> FlatNumbers(KeyValuePair<int, int> numberValue)
    {
        for (var i = 0; i < numberValue.Value; i++)
            yield return numberValue.Key;
    }
}