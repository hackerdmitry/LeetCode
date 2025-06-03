using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._1298._Maximum_Candies_You_Can_Get_from_Boxes;

public class Solution
{
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
    {
        var boxes = CreateBoxes(status, candies, keys, containedBoxes);
        return CountReceivedCandies(initialBoxes, boxes);
    }

    private int CountReceivedCandies(int[] initialBoxes, Box[] boxes)
    {
        var uncheckedBoxes = new Queue<Box>();
        var closedBoxes = new Dictionary<int, Box>();
        var keys = new HashSet<int>();

        foreach (var initialBox in initialBoxes)
            uncheckedBoxes.Enqueue(boxes[initialBox]);

        var candies = 0;

        while (uncheckedBoxes.Count > 0)
        {
            var box = uncheckedBoxes.Dequeue();
            if (!TryOpenBox(box, keys, closedBoxes))
                continue;
            candies += CheckInsideBox(box, keys, closedBoxes, uncheckedBoxes);
        }

        return candies;
    }

    private bool TryOpenBox(Box box, HashSet<int> keys, Dictionary<int, Box> closedBoxes)
    {
        if (box.IsOpen)
            return true;

        if (keys.Contains(box.Id))
        {
            box.IsOpen = true;
            keys.Remove(box.Id);
            return true;
        }

        closedBoxes.Add(box.Id, box);
        return false;
    }

    private int CheckInsideBox(Box box, HashSet<int> keys, Dictionary<int, Box> closedBoxes, Queue<Box> uncheckedBoxes)
    {
        if (box.IsChecked || !box.IsOpen)
            return 0;
        box.IsChecked = true;

        foreach (var boxKey in box.Keys)
        {
            keys.Add(boxKey);
            if (closedBoxes.TryGetValue(boxKey, out var closedBox))
            {
                uncheckedBoxes.Enqueue(closedBox);
                closedBoxes.Remove(boxKey);
            }
        }

        foreach (var containedBox in box.ContainedBoxes)
            uncheckedBoxes.Enqueue(containedBox);

        return box.Candies;
    }

    private Box[] CreateBoxes(int[] status, int[] candies, int[][] keys, int[][] containedBoxes)
    {
        var n = status.Length;
        var boxes = new Box[n];
        for (var i = 0; i < n; i++)
            boxes[i] = new Box(i, status[i] == 1, candies[i], keys[i]);
        for (var i = 0; i < n; i++)
            boxes[i].ContainedBoxes = containedBoxes[i].Select(j => boxes[j]).ToArray();
        return boxes;
    }

    private class Box
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public bool IsChecked { get; set; }
        public int Candies { get; set; }
        public int[] Keys { get; set; }
        public Box[] ContainedBoxes { get; set; }

        public Box(int id, bool isOpen, int candies, int[] keys)
        {
            Id = id;
            IsOpen = isOpen;
            Candies = candies;
            Keys = keys;
        }
    }
}