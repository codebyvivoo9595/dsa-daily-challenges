/*
========================================================
LeetCode Problem: 153. Find Minimum in Rotated Sorted Array
Pattern: Binary Search
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

--------------------------------------------------------
Problem Statement

Suppose an array sorted in ascending order is rotated
between 1 and n times.

Given the rotated array nums, return the minimum element.

Example:

Input:
nums = [3,4,5,1,2]

Output:
1

--------------------------------------------------------
Approach : Binary Search

Idea:
The minimum element is the pivot point.

Steps:
1. Compare mid with right
2. If nums[mid] > nums[right]
   → minimum is in right half
3. Else
   → minimum is in left half (including mid)

Time Complexity:
O(log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // Minimum is in right half
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                // Minimum is in left half including mid
                right = mid;
            }
        }

        return nums[left];
    }
}