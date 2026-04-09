/*
========================================================
LeetCode Problem: 35. Search Insert Position
Pattern: Binary Search (Lower Bound)
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/search-insert-position/

--------------------------------------------------------
Problem Statement

Given a sorted array of distinct integers and a target value,
return the index if the target is found.

If not, return the index where it would be inserted in order.

Example:

Input:
nums = [1,3,5,6], target = 5

Output:
2

Input:
nums = [1,3,5,6], target = 2

Output:
1

--------------------------------------------------------
Approach : Binary Search

Idea:
If target not found, return position where it should be inserted.

Key Insight:
At the end of binary search, left pointer gives insert position.

Time Complexity:
O(log n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
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

        // Insert position
        return left;
    }
}