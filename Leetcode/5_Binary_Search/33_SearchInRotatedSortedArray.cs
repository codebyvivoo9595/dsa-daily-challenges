/*
========================================================
LeetCode Problem: 33. Search in Rotated Sorted Array
Pattern: Binary Search
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/search-in-rotated-sorted-array/

--------------------------------------------------------
Problem Statement

There is an integer array nums sorted in ascending order,
but it is rotated at some pivot.

Given nums and a target, return its index or -1.

Example:

Input:
nums = [4,5,6,7,0,1,2], target = 0

Output:
4

--------------------------------------------------------
Approach : Modified Binary Search

Idea:
At least one half is always sorted.

Steps:
1. Find mid
2. Check which half is sorted
3. Decide where target lies
4. Move left or right

Time Complexity:
O(log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            // Left half is sorted
            if (nums[left] <= nums[mid])
            {
                if (target >= nums[left] && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            // Right half is sorted
            else
            {
                if (target > nums[mid] && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return -1;
    }
}