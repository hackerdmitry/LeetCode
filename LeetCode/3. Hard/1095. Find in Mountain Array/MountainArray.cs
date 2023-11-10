// This is MountainArray's API interface.
// You should not implement it, or speculate about its implementation

using System;

namespace LeetCode._1095._Find_in_Mountain_Array;

public class MountainArray
{
    private readonly int[] _array;

    private int getCount;

    public MountainArray(int[] array)
    {
        _array = array;
    }

    public int Get(int index)
    {
        getCount++;
        if (getCount > 100)
            throw new ArgumentOutOfRangeException();

        return _array[index];
    }

    public int Length()
    {
        return _array.Length;
    }
}