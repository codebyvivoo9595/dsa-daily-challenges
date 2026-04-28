/*
========================================================
LeetCode Problem: 300. Longest Increasing Subsequence
Pattern: Dynamic Programming
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/longest-increasing-subsequence/

--------------------------------------------------------
Problem Statement

Given an integer array nums, return the length of the
longest strictly increasing subsequence.

Example:

Input:
nums = [10,9,2,5,3,7,101,18]

Output:
4

Explanation:
[2,3,7,101]

--------------------------------------------------------
Approach #1 : DP (O(n^2))

Idea:
dp[i] = length of LIS ending at index i

For each i:
check all j < i

Time Complexity:
O(n^2)

--------------------------------------------------------
Approach #2 : Binary Search (Optimal)

Idea:
Maintain a list where:
- It stores smallest possible tail values

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
    /*
    ========================================================
    Approach #2 : Binary Search (Optimal)
    ========================================================
    */

    public int LengthOfLIS(int[] nums)
    {
        List<int> list = new List<int>();

        foreach (int num in nums)
        {
            int left = 0;
            int right = list.Count;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (list[mid] < num)
                    left = mid + 1;
                else
                    right = mid;
            }

            if (left == list.Count)
                list.Add(num);
            else
                list[left] = num;
        }

        return list.Count;
    }
}