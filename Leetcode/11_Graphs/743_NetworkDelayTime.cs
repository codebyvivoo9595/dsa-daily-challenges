/*
========================================================
LeetCode Problem: 743. Network Delay Time
Pattern: Advanced Graphs (Dijkstra / Shortest Path)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/network-delay-time/

--------------------------------------------------------
Problem Statement

You are given times where:

times[i] = [u, v, w]

u → source node
v → destination node
w → travel time

Return minimum time needed for signal to reach all nodes.

If impossible → return -1.

--------------------------------------------------------
Approach : Dijkstra (Priority Queue)

Idea:
1. Build adjacency list
2. Use Min Heap (PriorityQueue)
3. Always process shortest distance first
4. Relax neighbors

Time Complexity:
O((V + E) log V)

Space Complexity:
O(V + E)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        // Build graph
        Dictionary<int, List<(int neighbor, int weight)>> graph =
            new Dictionary<int, List<(int, int)>>();

        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<(int, int)>();
        }

        foreach (var time in times)
        {
            int u = time[0];
            int v = time[1];
            int w = time[2];

            graph[u].Add((v, w));
        }

        // Min Heap -> (distance, node)
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(k, 0);

        Dictionary<int, int> distance = new Dictionary<int, int>();

        while (pq.Count > 0)
        {
            pq.TryDequeue(out int node, out int dist);

            // Already visited
            if (distance.ContainsKey(node))
                continue;

            distance[node] = dist;

            foreach (var (neighbor, weight) in graph[node])
            {
                if (!distance.ContainsKey(neighbor))
                {
                    pq.Enqueue(neighbor, dist + weight);
                }
            }
        }

        if (distance.Count != n)
            return -1;

        int maxTime = 0;

        foreach (var time in distance.Values)
        {
            maxTime = Math.Max(maxTime, time);
        }

        return maxTime;
    }
}