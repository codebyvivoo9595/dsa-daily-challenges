/*
========================================================
LeetCode Problem: 15. 3Sum
Pattern: Two Pointers
Difficulty: Medium (Important)

LeetCode Link:
https://leetcode.com/problems/3sum/

--------------------------------------------------------
Problem Statement

Given an integer array nums, return all the triplets
[i, j, k] such that:

nums[i] + nums[j] + nums[k] == 0

The solution set must not contain duplicate triplets.

Example:

Input:
nums = [-1,0,1,2,-1,-4]

Output:
[[-1,-1,2],[-1,0,1]]

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Check all triplets using 3 loops.

Time Complexity:
O(n^3)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Sorting + Two Pointers (Optimal)

Idea:
1. Sort array
2. Fix one element
3. Use two pointers for remaining array

Steps:
1. Sort nums
2. Loop i from 0 to n
3. Use left = i+1, right = n-1
4. Find pairs such that sum = -nums[i]

Time Complexity:
O(n^2)

Space Complexity:
O(1) (excluding result)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    /*
    ========================================================
    Approach #1 : Brute Force
    ========================================================

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[j] + nums[k] == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    }
                }
            }
        }

        return result;
    }

    */

    // =====================================================
    // Approach #2 : Sorting + Two Pointers (Optimal)
    // =====================================================

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Skip duplicates for i
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicates for left
                    while (left < right && nums[left] == nums[left + 1])
                        left++;

                    // Skip duplicates for right
                    while (left < right && nums[right] == nums[right - 1])
                        right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}