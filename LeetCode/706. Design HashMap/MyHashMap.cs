using System.Collections.Generic;

namespace LeetCode._706._Design_HashMap
{
    public class MyHashMap
    {
        private readonly Dictionary<int, int> dictionary = new();

        public void Put(int key, int value)
        {
            dictionary[key] = value;
        }

        public int Get(int key)
        {
            return dictionary.TryGetValue(key, out var value) ? value : -1;
        }

        public void Remove(int key)
        {
            dictionary.Remove(key);
        }
    }
}