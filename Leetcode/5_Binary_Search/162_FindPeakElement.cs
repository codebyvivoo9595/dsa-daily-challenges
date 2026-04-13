/*
========================================================
LeetCode Problem: 162. Find Peak Element
Pattern: Binary Search
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/find-peak-element/

--------------------------------------------------------
Problem Statement

A peak element is an element that is strictly greater 
than its neighbors.

Given an integer array nums, find a peak element and 
return its index.

You may assume nums[-1] = nums[n] = -∞

Example:

Input:
nums = [1,2,3,1]

Output:
2  (index of 3)

--------------------------------------------------------
Approach : Binary Search

Idea:
Compare mid with next element.

1. If nums[mid] < nums[mid + 1]
   → peak lies on right side

2. Else
   → peak lies on left side (including mid)

Time Complexity:
O(log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] < nums[mid + 1])
            {
                // increasing → peak on right
                left = mid + 1;
            }
            else
            {
                // decreasing → peak on left (including mid)
                right = mid;
            }
        }

        return left;
    }
}