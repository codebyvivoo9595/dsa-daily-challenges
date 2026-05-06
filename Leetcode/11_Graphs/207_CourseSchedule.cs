/*
========================================================
LeetCode Problem: 207. Course Schedule
Pattern: Graphs (Cycle Detection / Topological Sort)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/course-schedule/

--------------------------------------------------------
Problem Statement

There are numCourses courses labeled from 0 to n-1.

You are given prerequisites where:
[a, b] means → to take course 'a' you must first take 'b'.

Return true if you can finish all courses.

--------------------------------------------------------
Approach : DFS (Cycle Detection)

Idea:
- If cycle exists → not possible to finish
- Detect cycle using recursion stack

States:
0 → unvisited
1 → visiting
2 → visited

Time Complexity:
O(V + E)

Space Complexity:
O(V)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        List<int>[] graph = new List<int>[numCourses];

        for (int i = 0; i < numCourses; i++)
            graph[i] = new List<int>();

        // Build graph
        foreach (var pre in prerequisites)
        {
            graph[pre[1]].Add(pre[0]);
        }

        int[] state = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            if (!DFS(graph, state, i))
                return false;
        }

        return true;
    }

    private bool DFS(List<int>[] graph, int[] state, int node)
    {
        if (state[node] == 1) return false; // cycle
        if (state[node] == 2) return true;  // already processed

        state[node] = 1; // visiting

        foreach (int neighbor in graph[node])
        {
            if (!DFS(graph, state, neighbor))
                return false;
        }

        state[node] = 2; // visited
        return true;
    }
}