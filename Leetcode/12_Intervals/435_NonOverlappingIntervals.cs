/*
========================================================
LeetCode Problem: 435. Non-overlapping Intervals
Pattern: Intervals + Greedy
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/non-overlapping-intervals/

--------------------------------------------------------
Problem Statement

Given intervals,
return minimum number of intervals to remove
to make remaining intervals non-overlapping.

Example:

Input:
[[1,2],[2,3],[3,4],[1,3]]

Output:
1

Explanation:
Remove [1,3]

--------------------------------------------------------
Approach : Greedy

Idea:
1. Sort by end time
2. Keep interval with smaller end
3. If overlap → remove one

Why smaller end?
Leaves more room for future intervals.

Time Complexity:
O(n log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        // Sort by end time
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int removals = 0;
        int prevEnd = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            // Overlap
            if (intervals[i][0] < prevEnd)
            {
                removals++;
            }
            else
            {
                prevEnd = intervals[i][1];
            }
        }

        return removals;
    }
}