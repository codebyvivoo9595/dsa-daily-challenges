/*
========================================================
LeetCode Problem: 46. Permutations
Pattern: Backtracking
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/permutations/

--------------------------------------------------------
Problem Statement

Given an array nums of distinct integers,
return all possible permutations.

Example:

Input:
nums = [1,2,3]

Output:
[
 [1,2,3],
 [1,3,2],
 [2,1,3],
 [2,3,1],
 [3,1,2],
 [3,2,1]
]

--------------------------------------------------------
Approach : Backtracking

Idea:
At each step → pick any unused element

Steps:
1. Track used elements
2. Build permutation
3. When size == n → add to result

Time Complexity:
O(n * n!)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();
        bool[] used = new bool[nums.Length];

        Backtrack(nums, current, used, result);

        return result;
    }

    private void Backtrack(int[] nums, List<int> current, bool[] used, IList<IList<int>> result)
    {
        if (current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;

            // Choose
            used[i] = true;
            current.Add(nums[i]);

            // Explore
            Backtrack(nums, current, used, result);

            // Backtrack
            used[i] = false;
            current.RemoveAt(current.Count - 1);
        }
    }
}