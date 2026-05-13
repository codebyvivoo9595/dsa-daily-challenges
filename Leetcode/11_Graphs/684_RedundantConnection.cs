/*
========================================================
LeetCode Problem: 684. Redundant Connection
Pattern: Advanced Graphs (Union Find / DSU)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/redundant-connection/

--------------------------------------------------------
Problem Statement

A tree with n nodes has exactly n-1 edges.

One extra edge is added.

Return the edge that creates a cycle.

Example:

Input:
edges = [[1,2],[1,3],[2,3]]

Output:
[2,3]

--------------------------------------------------------
Approach : Union Find (DSU)

Idea:
- If two nodes already belong to same parent
  → cycle found

Union Find Operations:
1. Find → find parent
2. Union → connect sets

Time Complexity:
O(n)

Space Complexity:
O(n)

========================================================
*/

using System;

public class Solution
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        int n = edges.Length;

        int[] parent = new int[n + 1];

        // Initialize parent
        for (int i = 1; i <= n; i++)
        {
            parent[i] = i;
        }

        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];

            int parentU = Find(parent, u);
            int parentV = Find(parent, v);

            // Cycle detected
            if (parentU == parentV)
                return edge;

            // Union
            parent[parentU] = parentV;
        }

        return new int[] { };
    }

    private int Find(int[] parent, int node)
    {
        if (parent[node] != node)
        {
            parent[node] = Find(parent, parent[node]); // Path compression
        }

        return parent[node];
    }
}