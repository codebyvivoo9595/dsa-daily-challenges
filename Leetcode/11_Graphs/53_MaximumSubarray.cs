/*
========================================================
LeetCode Problem: 53. Maximum Subarray
Pattern: Greedy (Kadane's Algorithm)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/maximum-subarray/

--------------------------------------------------------
Problem Statement

Given an integer array nums, find the contiguous
subarray with the largest sum.

Return its sum.

Example:

Input:
nums = [-2,1,-3,4,-1,2,1,-5,4]

Output:
6

Explanation:
[4,-1,2,1] = 6

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Try every possible subarray and calculate sum.

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Greedy (Kadane's Algorithm)

Idea:
If current sum becomes negative,
start fresh from current element.

Formula:
currentSum = max(nums[i], currentSum + nums[i])
maxSum = max(maxSum, currentSum)

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    /*
    ========================================================
    Approach #1 : Brute Force (Commented)
    ========================================================

    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;

            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                maxSum = Math.Max(maxSum, sum);
            }
        }

        return maxSum;
    }
    */

    /*
    ========================================================
    Approach #2 : Greedy (Kadane's Algorithm)
    ========================================================
    */

    public int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}