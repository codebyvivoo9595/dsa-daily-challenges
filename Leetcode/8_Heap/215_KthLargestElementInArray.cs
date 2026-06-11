/*
========================================================
LeetCode Problem: 215. Kth Largest Element in an Array
Pattern: Heap (Priority Queue)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/kth-largest-element-in-an-array/

--------------------------------------------------------
Problem Statement

Given an integer array nums and an integer k,
return the kth largest element in the array.

Example:

Input:
nums = [3,2,1,5,6,4], k = 2

Output:
5

--------------------------------------------------------
Approach #1 : Sorting

Sort array and pick kth largest.

Time Complexity:
O(n log n)

--------------------------------------------------------
Approach #2 : Min Heap (Optimal)

Idea:
Maintain a heap of size k.

Steps:
1. Add elements to heap
2. If size > k → remove smallest
3. Top of heap = kth largest

Time Complexity:
O(n log k)

Space Complexity:
O(k)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // Min Heap
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            minHeap.Enqueue(num, num);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue(); // remove smallest
            }
        }

        return minHeap.Peek();
    }
}