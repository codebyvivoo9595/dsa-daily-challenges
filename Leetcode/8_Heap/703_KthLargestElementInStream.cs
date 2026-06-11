/*
========================================================
LeetCode Problem: 703. Kth Largest Element in a Stream
Pattern: Heap (Streaming + Top K)
Difficulty: Easy-Medium

LeetCode Link:
https://leetcode.com/problems/kth-largest-element-in-a-stream/

--------------------------------------------------------
Problem Statement

Design a class to find the kth largest element in a stream.

You will be given:
- k (size)
- initial array nums

Then multiple values will be added.

Return kth largest element after each addition.

Example:

Input:
["KthLargest", "add", "add", "add", "add", "add"]
[[3, [4,5,8,2]], [3], [5], [10], [9], [4]]

Output:
[null, 4, 5, 5, 8, 8]

--------------------------------------------------------
Approach : Min Heap

Idea:
Maintain a min heap of size k.

Steps:
1. Initialize heap with nums
2. Keep only k largest elements
3. For each add:
   - Insert value
   - If size > k → remove smallest
4. Top = kth largest

Time Complexity:
O(log k) per operation

Space Complexity:
O(k)

========================================================
*/

using System;
using System.Collections.Generic;

public class KthLargest
{
    private PriorityQueue<int, int> minHeap;
    private int k;

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            minHeap.Enqueue(num, num);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }
    }

    public int Add(int val)
    {
        minHeap.Enqueue(val, val);

        if (minHeap.Count > k)
        {
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}