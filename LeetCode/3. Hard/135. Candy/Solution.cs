using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._135._Candy;

public class Solution
{
    public int Candy(int[] ratings)
    {
        var children = CreateChildren(ratings);
        CountCandies(children);
        return children.Sum(x => x.CandiesCount);
    }

    private Child[] CreateChildren(int[] ratings)
    {
        var children = new Child[ratings.Length];
        for (var i = 0; i < ratings.Length; i++)
            children[i] = new Child
            {
                Id = i,
                CandiesCount = 1,
                Rating = ratings[i],
            };
        foreach (var child in children)
            child.IsHigher = IsHigher(ratings, child.Id);

        return children;
    }

    private void CountCandies(Child[] children)
    {
        var queue = new PriorityQueue<Child, int>();
        foreach (var child in children)
            if (child.IsHigher)
                queue.Enqueue(child, child.Rating);

        while (queue.Count > 0)
        {
            var child = queue.Dequeue();
            child.CandiesCount = GetLowerNeighbours(child, children).Max(x => x.CandiesCount) + 1;
        }
    }

    private IEnumerable<Child> GetLowerNeighbours(Child child, Child[] children)
    {
        if (child.Id > 0 && children[child.Id - 1].Rating < child.Rating)
            yield return children[child.Id - 1];

        if (child.Id < children.Length - 1 && children[child.Id + 1].Rating < child.Rating)
            yield return children[child.Id + 1];
    }

    private bool IsHigher(int[] ratings, int index)
    {
        if (ratings.Length == 1)
            return false;

        if (index == 0)
            return ratings[0] > ratings[1];

        if (index == ratings.Length - 1)
            return ratings[^1] > ratings[^2];

        return ratings[index - 1] < ratings[index] || ratings[index] > ratings[index + 1];
    }

    private class Child
    {
        public int Id { get; set; }
        public bool IsHigher { get; set; }
        public int CandiesCount { get; set; }
        public int Rating { get; set; }
        public bool IsCounted { get; set; }

        public override string ToString()
        {
            return $"[{Id} - {Rating} - {(IsHigher ? 'H' : 'L')}]: {CandiesCount} {(IsCounted ? '+' : '-')}";
        }
    }
}
