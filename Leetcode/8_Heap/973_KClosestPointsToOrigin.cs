/*
========================================================
LeetCode Problem: 973. K Closest Points to Origin
Pattern: Heap (Top K + Custom Priority)
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/k-closest-points-to-origin/

--------------------------------------------------------
Problem Statement

Given an array of points where points[i] = [x, y],
return the k closest points to the origin (0,0).

Distance = x^2 + y^2

Example:

Input:
points = [[1,3],[-2,2]], k = 1

Output:
[[-2,2]]

--------------------------------------------------------
Approach #1 : Sorting

Sort all points based on distance.

Time Complexity:
O(n log n)

--------------------------------------------------------
Approach #2 : Max Heap (Optimal)

Idea:
1. Use max heap of size k
2. Store points with distance
3. If size > k → remove farthest point

Time Complexity:
O(n log k)

Space Complexity:
O(k)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        // Max Heap (use negative distance to simulate max heap)
        PriorityQueue<int[], int> maxHeap = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            int x = point[0];
            int y = point[1];

            int dist = x * x + y * y;

            // negative distance for max heap behavior
            maxHeap.Enqueue(point, -dist);

            if (maxHeap.Count > k)
            {
                maxHeap.Dequeue(); // remove farthest
            }
        }

        int[][] result = new int[k][];

        for (int i = 0; i < k; i++)
        {
            result[i] = maxHeap.Dequeue();
        }

        return result;
    }
}