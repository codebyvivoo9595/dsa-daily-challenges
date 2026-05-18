/*
========================================================
LeetCode Problem: 547. Number of Provinces
Pattern: Advanced Graphs (Union Find / DFS)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/number-of-provinces/

--------------------------------------------------------
Problem Statement

There are n cities.

isConnected[i][j] = 1 means city i and city j are connected.

A province is a group of directly or indirectly connected cities.

Return total number of provinces.

--------------------------------------------------------
Approach : Union Find (DSU)

Idea:
1. Initially every city is its own province
2. If connected → union
3. Final unique parents = provinces

Time Complexity:
O(n^2)

Space Complexity:
O(n)

========================================================
*/

using System;

public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;

        int[] parent = new int[n];
        int provinces = n;

        // Initialize parent
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (isConnected[i][j] == 1)
                {
                    int parentI = Find(parent, i);
                    int parentJ = Find(parent, j);

                    if (parentI != parentJ)
                    {
                        parent[parentI] = parentJ;
                        provinces--;
                    }
                }
            }
        }

        return provinces;
    }

    private int Find(int[] parent, int node)
    {
        if (parent[node] != node)
        {
            parent[node] = Find(parent, parent[node]);
        }

        return parent[node];
    }
}