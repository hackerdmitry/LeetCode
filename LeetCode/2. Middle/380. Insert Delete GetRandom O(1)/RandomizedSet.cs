using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._380._Insert_Delete_GetRandom_O_1_;

public class RandomizedSet
{
    private readonly HashSet<int> set = new();

    public bool Insert(int val) => set.Add(val);

    public bool Remove(int val) => set.Remove(val);

    public int GetRandom() => set.Skip(Random.Shared.Next(set.Count)).First();
}