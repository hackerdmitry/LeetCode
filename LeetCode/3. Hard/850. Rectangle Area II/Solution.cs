using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._850._Rectangle_Area_II;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int RectangleArea(int[][] rectangles)
    {
        if (rectangles == null || rectangles.Length == 0)
            return 0;

        // Собираем все y-координаты для сжатия
        var yCoords = new HashSet<int>();
        var events = new List<Event>();

        foreach (var rect in rectangles)
        {
            int x1 = rect[0], y1 = rect[1], x2 = rect[2], y2 = rect[3];

            yCoords.Add(y1);
            yCoords.Add(y2);

            // Событие начала прямоугольника
            events.Add(new Event(x1, y1, y2, 1));
            // Событие конца прямоугольника
            events.Add(new Event(x2, y1, y2, -1));
        }

        // Сортируем y-координаты и создаем карту сжатия
        var sortedY = yCoords.ToList();
        sortedY.Sort();

        // Создаем массив длин сегментов между y-координатами
        var segmentLengths = new long[sortedY.Count - 1];
        for (var i = 0; i < segmentLengths.Length; i++)
        {
            segmentLengths[i] = sortedY[i + 1] - sortedY[i];
        }

        // Словарь для быстрого поиска индекса y-координаты
        var yToIndex = new Dictionary<int, int>();
        for (var i = 0; i < sortedY.Count; i++)
        {
            yToIndex[sortedY[i]] = i;
        }

        // Сортируем события по x-координате
        events.Sort((a, b) => a.x.CompareTo(b.x));

        // Инициализируем дерево отрезков
        var root = new SegmentTreeNode(0, segmentLengths.Length - 1, segmentLengths);

        long totalArea = 0;
        var prevX = events[0].x;

        // Обрабатываем события
        for (var i = 0; i < events.Count; i++)
        {
            var ev = events[i];

            // Добавляем площадь от предыдущего события до текущего
            if (ev.x > prevX)
            {
                var coveredLength = root.length;
                totalArea += coveredLength * (ev.x - prevX);
            }

            // Обновляем дерево отрезков
            root.Update(yToIndex[ev.y1], yToIndex[ev.y2] - 1, ev.type);

            prevX = ev.x;
        }

        return (int) (totalArea % modulo);
    }

    // Структура для хранения события сканирующей прямой
    private struct Event
    {
        public int x;
        public int y1;
        public int y2;
        public int type; // 1 - начало прямоугольника, -1 - конец прямоугольника

        public Event(int x, int y1, int y2, int type)
        {
            this.x = x;
            this.y1 = y1;
            this.y2 = y2;
            this.type = type;
        }

        public override string ToString()
        {
            return $"x={x}, y1={y1}, y2={y2}, type={type}";
        }
    }

    // Узел дерева отрезков
    private class SegmentTreeNode
    {
        public long length; // длина покрытого отрезка (в реальных координатах)

        private int count; // количество покрывающих интервалов
        private readonly bool isLeaf;

        private readonly int left;
        private readonly int mid;
        private readonly int right;

        private readonly SegmentTreeNode leftNode;
        private readonly SegmentTreeNode rightNode;

        public SegmentTreeNode(int left, int right, long[] segmentLengths)
        {
            this.left = left;
            this.right = right;

            isLeaf = left == right;
            if (!isLeaf)
            {
                mid = (left + right) / 2;
                leftNode = new SegmentTreeNode(left, mid, segmentLengths);
                rightNode = new SegmentTreeNode(mid + 1, right, segmentLengths);
            }
            else
                length = segmentLengths[left];
        }

        public void Update(int from, int to, int value)
        {
            if (isLeaf)
                count += value;
            else
            {
                if (left <= from && from <= mid)
                    leftNode.Update(from, Math.Min(mid, to), value);
                if (mid < to && to <= right)
                    rightNode.Update(Math.Max(mid + 1, from), to, value);
                length = leftNode.GetLength() + rightNode.GetLength();
            }
        }

        public override string ToString()
        {
            return $"[{left} -> {right}]: count={count}, length={length}";
        }

        private long GetLength()
        {
            return !isLeaf || count > 0 ? length : 0;
        }
    }
}