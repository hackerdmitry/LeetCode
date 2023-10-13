namespace LeetCode._1095._Find_in_Mountain_Array
{
    class Solution
    {
        public int FindInMountainArray(int target, MountainArray mountainArr)
        {
            var vertex = FindVertex(mountainArr);
//            Console.WriteLine($"Vertex in index: {vertex}"); // DEBUG

            var searchLeft = Search(mountainArr, target, -1, vertex, true);
            if (searchLeft != -1)
                return searchLeft;
//            Console.WriteLine($"Search left: {searchLeft}"); // DEBUG

            var searchRight = Search(mountainArr, target, vertex, -1, false);
//            Console.WriteLine($"Search right: {searchRight}"); // DEBUG

            return searchRight;
        }

        private int Search(MountainArray arr, int target, int left = -1, int right = -1, bool isAsc = true)
        {
            var length = arr.Length();
            if (left == -1) left = 0;
            if (right == -1) right = length - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;
                var value = arr.Get(middle);

                if (target == value)
                    return middle;

                if (target < value && isAsc)
                    right = middle;
                else if (left == middle)
                    left++;
                else
                    left = middle;
            }

            var endValue = arr.Get(right);
            return endValue == target ? right : -1;
        }

        private int FindVertex(MountainArray arr)
        {
            var left = 0;
            var right = arr.Length() - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;
                var rightMiddle = middle + 1;

                var middleValue = arr.Get(middle);
                var rightMiddleValue = arr.Get(rightMiddle);

                if (middleValue < rightMiddleValue)
                {
                    left = rightMiddle;
                }
                else
                {
                    right = middle;
                }
            }

            return right;
        }
    }
}