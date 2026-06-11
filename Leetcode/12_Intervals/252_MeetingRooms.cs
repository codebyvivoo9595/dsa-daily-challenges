/*
========================================================
LeetCode Problem: 252. Meeting Rooms
Pattern: Intervals
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/meeting-rooms/

--------------------------------------------------------
Problem Statement

Given meeting intervals:

[start, end]

Return true if person can attend all meetings.

Example:

Input:
[[0,30],[5,10],[15,20]]

Output:
false

--------------------------------------------------------
Approach : Sort + Check Overlap

Idea:
1. Sort by start time
2. Compare adjacent meetings
3. If overlap → impossible

Time Complexity:
O(n log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        // Sort by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        for (int i = 1; i < intervals.Length; i++)
        {
            // Overlap
            if (intervals[i][0] < intervals[i - 1][1])
            {
                return false;
            }
        }

        return true;
    }
}