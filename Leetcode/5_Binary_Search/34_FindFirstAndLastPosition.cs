/*
========================================================
LeetCode Problem: 34. Find First and Last Position of Element in Sorted Array
Pattern: Binary Search (Bound Search)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

--------------------------------------------------------
Problem Statement

Given an array of integers nums sorted in non-decreasing order,
find the starting and ending position of a given target value.

If target is not found, return [-1, -1].

Example:

Input:
nums = [5,7,7,8,8,10], target = 8

Output:
[3,4]

--------------------------------------------------------
Approach : Binary Search (Left Bound + Right Bound)

Idea:
1. Find first occurrence (leftmost index)
2. Find last occurrence (rightmost index)

Time Complexity:
O(log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirst(nums, target);
        int last = FindLast(nums, target);

        return new int[] { first, last };
    }

    // Find first occurrence
    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                right = mid - 1; // move left
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    // Find last occurrence
    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                left = mid + 1; // move right
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}