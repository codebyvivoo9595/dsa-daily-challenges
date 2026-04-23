/*
========================================================
LeetCode Problem: 90. Subsets II
Pattern: Backtracking
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/subsets-ii/

--------------------------------------------------------
Problem Statement

Given an integer array nums that may contain duplicates,
return all possible subsets (the power set).

The solution set must not contain duplicate subsets.

Example:

Input:
nums = [1,2,2]

Output:
[
 [],
 [1],
 [2],
 [1,2],
 [2,2],
 [1,2,2]
]

--------------------------------------------------------
Approach : Backtracking + Sorting

Idea:
1. Sort array
2. Skip duplicates while iterating

Condition:
if (i > index && nums[i] == nums[i-1]) → skip

Time Complexity:
O(n * 2^n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums); // IMPORTANT

        IList<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();

        Backtrack(nums, 0, current, result);

        return result;
    }

    private void Backtrack(int[] nums, int index, List<int> current, IList<IList<int>> result)
    {
        result.Add(new List<int>(current));

        for (int i = index; i < nums.Length; i++)
        {
            // Skip duplicates
            if (i > index && nums[i] == nums[i - 1])
                continue;

            // Choose
            current.Add(nums[i]);

            // Explore
            Backtrack(nums, i + 1, current, result);

            // Backtrack
            current.RemoveAt(current.Count - 1);
        }
    }
}