/*
========================================================
LeetCode Problem: 1539. Kth Missing Positive Number
Pattern: Binary Search
Difficulty: Easy-Medium

LeetCode Link:
https://leetcode.com/problems/kth-missing-positive-number/

--------------------------------------------------------
Problem Statement

Given a sorted array arr of positive integers and an integer k,
return the kth missing positive integer.

Example:

Input:
arr = [2,3,4,7,11], k = 5

Output:
9

Explanation:
Missing numbers = [1,5,6,8,9,10,...]
5th missing = 9

--------------------------------------------------------
Approach #1 : Brute Force

Check numbers one by one.

Time Complexity:
O(n + k)

--------------------------------------------------------
Approach #2 : Binary Search

Idea:
Count how many numbers are missing till index i.

Formula:
missing = arr[i] - (i + 1)

Steps:
1. Binary search to find first index where missing >= k
2. Answer = k + left

Time Complexity:
O(log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    /*
    ========================================================
    Approach #1 : Brute Force
    ========================================================

    public int FindKthPositive(int[] arr, int k)
    {
        int current = 1;
        int i = 0;

        while (k > 0)
        {
            if (i < arr.Length && arr[i] == current)
            {
                i++;
            }
            else
            {
                k--;
                if (k == 0)
                    return current;
            }
            current++;
        }

        return current;
    }

    */

    // =====================================================
    // Approach #2 : Binary Search (Optimal)
    // =====================================================

    public int FindKthPositive(int[] arr, int k)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int missing = arr[mid] - (mid + 1);

            if (missing < k)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        // Final answer
        return left + k;
    }
}