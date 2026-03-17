/*
========================================================
LeetCode Problem: 347. Top K Frequent Elements
Pattern: Arrays / Hashing + Heap
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/top-k-frequent-elements/

--------------------------------------------------------
Problem Statement

Given an integer array nums and an integer k, return
the k most frequent elements.

Example:

Input:
nums = [1,1,1,2,2,3], k = 2

Output:
[1,2]

--------------------------------------------------------
Approach #1 : Sorting by Frequency

Idea:
1. Count frequency using HashMap
2. Sort based on frequency
3. Pick top k elements

Time Complexity:
O(n log n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #2 : Min Heap

Idea:
1. Count frequency using HashMap
2. Use Min Heap of size k
3. Keep only top k frequent elements

Time Complexity:
O(n log k)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #3 : Bucket Sort (Optimal)

Idea:
Frequency can range from 1 to n

So:
1. Create array of buckets (index = frequency)
2. Store numbers in buckets
3. Traverse from high frequency to low

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
    /*
    ========================================================
    Approach #1 : Sorting
    ========================================================

    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        var sorted = new List<KeyValuePair<int, int>>(freqMap);
        sorted.Sort((a, b) => b.Value.CompareTo(a.Value));

        int[] result = new int[k];

        for(int i = 0; i < k; i++)
        {
            result[i] = sorted[i].Key;
        }

        return result;
    }

    */

    /*
    ========================================================
    Approach #2 : Min Heap
    ========================================================

    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach(var entry in freqMap)
        {
            minHeap.Enqueue(entry.Key, entry.Value);

            if(minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        int[] result = new int[k];

        for(int i = k - 1; i >= 0; i--)
        {
            result[i] = minHeap.Dequeue();
        }

        return result;
    }

    */

    // =====================================================
    // Approach #3 : Bucket Sort (Optimal)
    // =====================================================

    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        // Bucket array
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var entry in freqMap)
        {
            int freq = entry.Value;

            if (buckets[freq] == null)
                buckets[freq] = new List<int>();

            buckets[freq].Add(entry.Key);
        }

        List<int> result = new List<int>();

        // Traverse from highest frequency
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return result.GetRange(0, k).ToArray();
    }
}