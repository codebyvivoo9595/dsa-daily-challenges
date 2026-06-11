/*
========================================================
LeetCode Problem: 253. Meeting Rooms II
Pattern: Intervals + Heap
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/meeting-rooms-ii/

--------------------------------------------------------
Problem Statement

Given meeting intervals:

[start, end]

Return minimum number of meeting rooms required.

Example:

Input:
[[0,30],[5,10],[15,20]]

Output:
2

--------------------------------------------------------
Approach : Sort + Min Heap

Idea:
1. Sort meetings by start time
2. Min Heap stores meeting end times
3. If earliest meeting ends before current starts
   → reuse room
4. Otherwise → need new room

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
    public int MinMeetingRooms(int[][] intervals)
    {
        if (intervals.Length == 0)
            return 0;

        // Sort by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        // Min Heap -> end times
        PriorityQueue<int, int> minHeap =
            new PriorityQueue<int, int>();

        // First meeting
        minHeap.Enqueue(intervals[0][1], intervals[0][1]);

        for (int i = 1; i < intervals.Length; i++)
        {
            // Earliest room available
            minHeap.TryPeek(out int earliestEnd, out _);

            // Reuse room
            if (intervals[i][0] >= earliestEnd)
            {
                minHeap.Dequeue();
            }

            // Add current meeting
            minHeap.Enqueue(intervals[i][1], intervals[i][1]);
        }

        return minHeap.Count;
    }
}