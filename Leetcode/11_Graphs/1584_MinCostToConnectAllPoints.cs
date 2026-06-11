/*
========================================================
LeetCode Problem: 1584. Min Cost to Connect All Points
Pattern: Advanced Graphs (Minimum Spanning Tree - Prim's)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/min-cost-to-connect-all-points/

--------------------------------------------------------
Problem Statement

You are given points on 2D plane.

Cost to connect two points:

|x1 - x2| + |y1 - y2|

Return minimum cost to connect all points.

All points must be connected.

--------------------------------------------------------
Approach : Prim's Algorithm (MST)

Idea:
1. Start from any point
2. Use Min Heap to pick minimum edge
3. Add new point to MST
4. Repeat until all points connected

Time Complexity:
O(n² log n)

Space Complexity:
O(n²)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int MinCostConnectPoints(int[][] points)
    {
        int n = points.Length;

        HashSet<int> visited = new HashSet<int>();

        // (cost, node)
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(0, 0);

        int totalCost = 0;

        while (visited.Count < n)
        {
            pq.TryDequeue(out int node, out int cost);

            if (visited.Contains(node))
                continue;

            visited.Add(node);
            totalCost += cost;

            for (int next = 0; next < n; next++)
            {
                if (!visited.Contains(next))
                {
                    int distance =
                        Math.Abs(points[node][0] - points[next][0]) +
                        Math.Abs(points[node][1] - points[next][1]);

                    pq.Enqueue(next, distance);
                }
            }
        }

        return totalCost;
    }
}