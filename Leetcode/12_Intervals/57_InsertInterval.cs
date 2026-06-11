/*
========================================================
LeetCode Problem: 57. Insert Interval
Pattern: Intervals
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/insert-interval/

--------------------------------------------------------
Problem Statement

You are given:
intervals = non-overlapping intervals
newInterval = interval to insert

Insert and merge if needed.

Example:

Input:
intervals = [[1,3],[6,9]]
newInterval = [2,5]

Output:
[[1,5],[6,9]]

--------------------------------------------------------
Approach : Three Phases

Idea:
1. Add intervals before newInterval
2. Merge overlapping intervals
3. Add remaining intervals

Time Complexity:
O(n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new List<int[]>();
        int i = 0;
        int n = intervals.Length;

        // Step 1: Add non-overlapping before
        while (i < n && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        // Step 2: Merge overlaps
        while (i < n && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }

        result.Add(newInterval);

        // Step 3: Add remaining
        while (i < n)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}