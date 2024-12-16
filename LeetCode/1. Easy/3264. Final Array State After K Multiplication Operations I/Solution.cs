using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._3264._Final_Array_State_After_K_Multiplication_Operations_I;

public class Solution
{
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var priorityQueue = new PriorityQueue<Element, long>(nums.Select((x, i) => new Element(x, i)).Select(x => (x, x.GetPriority())));
        for (var i = 0; i < k; i++)
        {
            var element = priorityQueue.Dequeue();
            element.Value *= multiplier;
            nums[element.Index] = element.Value;
            priorityQueue.Enqueue(element, element.GetPriority());
        }

        return nums;
    }

    private class Element
    {
        public int Value { get; set; }
        public int Index { get; set; }

        public Element(int value, int index)
        {
            Value = value;
            Index = index;
        }

        public long GetPriority() => Value * 100L + Index;
    }
}
