/*
========================================================
LeetCode Problem: 704. Binary Search
Pattern: Binary Search
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/binary-search/

--------------------------------------------------------
Problem Statement

Given a sorted array of integers nums and an integer target,
return the index of target if it exists, otherwise return -1.

Example:

Input:
nums = [-1,0,3,5,9,12], target = 9

Output:
4

--------------------------------------------------------
Approach : Binary Search

Idea:
1. Use two pointers: left and right
2. Find mid
3. Compare nums[mid] with target
4. Adjust search space

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
            {
                return mid;
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

        return -1;
    }
}