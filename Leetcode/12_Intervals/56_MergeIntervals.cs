/*
========================================================
LeetCode Problem: 56. Merge Intervals
Pattern: Intervals
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/merge-intervals/

--------------------------------------------------------
Problem Statement

Given an array of intervals:

intervals[i] = [start, end]

Merge all overlapping intervals and return result.

Example:

Input:
[[1,3],[2,6],[8,10],[15,18]]

Output:
[[1,6],[8,10],[15,18]]

--------------------------------------------------------
Approach : Sorting + Merge

Idea:
1. Sort intervals by start time
2. Compare current interval with last merged
3. Overlap → merge
4. No overlap → add new interval

Time Complexity:
O(n log n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        // Sort by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new List<int[]>();

        foreach (var interval in intervals)
        {
            // First interval OR no overlap
            if (result.Count == 0 ||
                result[result.Count - 1][1] < interval[0])
            {
                result.Add(interval);
            }
            else
            {
                // Merge overlap
                result[result.Count - 1][1] =
                    Math.Max(result[result.Count - 1][1], interval[1]);
            }
        }

        return result.ToArray();
    }
}