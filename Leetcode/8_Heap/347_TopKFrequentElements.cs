/*
========================================================
LeetCode Problem: 347. Top K Frequent Elements
Pattern: Heap (Top K + Frequency)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/top-k-frequent-elements/

--------------------------------------------------------
Problem Statement

Given an integer array nums and an integer k,
return the k most frequent elements.

Example:

Input:
nums = [1,1,1,2,2,3], k = 2

Output:
[1,2]

--------------------------------------------------------
Approach #1 : Sorting

Count frequency → sort → pick top k

Time Complexity:
O(n log n)

--------------------------------------------------------
Approach #2 : Min Heap (Optimal)

Idea:
1. Count frequency using dictionary
2. Use min heap of size k
3. Keep top k frequent elements

Time Complexity:
O(n log k)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Step 1: Frequency map
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        // Step 2: Min Heap based on frequency
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (var kvp in freqMap)
        {
            int num = kvp.Key;
            int freq = kvp.Value;

            minHeap.Enqueue(num, freq);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue(); // remove least frequent
            }
        }

        // Step 3: Extract results
        int[] result = new int[k];
        int index = 0;

        while (minHeap.Count > 0)
        {
            result[index++] = minHeap.Dequeue();
        }

        return result;
    }
}