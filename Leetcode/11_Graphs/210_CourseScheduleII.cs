/*
========================================================
LeetCode Problem: 210. Course Schedule II
Pattern: Graphs (Topological Sort - BFS/Kahn's Algorithm)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/course-schedule-ii/

--------------------------------------------------------
Problem Statement

Return the ordering of courses you should take
to finish all courses.

If impossible → return empty array.

--------------------------------------------------------
Approach : Topological Sort (Kahn's Algorithm)

Idea:
1. Build graph
2. Calculate indegree
3. Add indegree 0 nodes to queue
4. Process BFS
5. Reduce neighbors indegree

If all nodes processed → valid order

Time Complexity:
O(V + E)

Space Complexity:
O(V + E)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        List<int>[] graph = new List<int>[numCourses];
        int[] indegree = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }

        // Build graph
        foreach (var pre in prerequisites)
        {
            int course = pre[0];
            int prerequisite = pre[1];

            graph[prerequisite].Add(course);
            indegree[course]++;
        }

        Queue<int> queue = new Queue<int>();

        // Add indegree 0 nodes
        for (int i = 0; i < numCourses; i++)
        {
            if (indegree[i] == 0)
                queue.Enqueue(i);
        }

        List<int> result = new List<int>();

        // BFS
        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            result.Add(current);

            foreach (int neighbor in graph[current])
            {
                indegree[neighbor]--;

                if (indegree[neighbor] == 0)
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Cycle check
        if (result.Count != numCourses)
            return new int[] { };

        return result.ToArray();
    }
}