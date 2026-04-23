/*
========================================================
LeetCode Problem: 78. Subsets
Pattern: Backtracking
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/subsets/

--------------------------------------------------------
Problem Statement

Given an integer array nums, return all possible subsets.

Example:

Input:
nums = [1,2,3]

Output:
[
 [],
 [1],
 [2],
 [3],
 [1,2],
 [1,3],
 [2,3],
 [1,2,3]
]

--------------------------------------------------------
Approach : Backtracking

Idea:
At each element → choose or not choose

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
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();

        Backtrack(nums, 0, current, result);

        return result;
    }

    private void Backtrack(int[] nums, int index, List<int> current, IList<IList<int>> result)
    {
        // Add current subset
        result.Add(new List<int>(current));

        for (int i = index; i < nums.Length; i++)
        {
            // Choose
            current.Add(nums[i]);

            // Explore
            Backtrack(nums, i + 1, current, result);

            // Backtrack (undo)
            current.RemoveAt(current.Count - 1);
        }
    }
}