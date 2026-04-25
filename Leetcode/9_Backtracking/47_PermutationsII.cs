/*
========================================================
LeetCode Problem: 47. Permutations II
Pattern: Backtracking
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/permutations-ii/

--------------------------------------------------------
Problem Statement

Given an array nums that may contain duplicates,
return all unique permutations.

Example:

Input:
nums = [1,1,2]

Output:
[
 [1,1,2],
 [1,2,1],
 [2,1,1]
]

--------------------------------------------------------
Approach : Backtracking + Sorting

Idea:
1. Sort array
2. Use visited array
3. Skip duplicates carefully

Condition:
if (i > 0 && nums[i] == nums[i-1] && !used[i-1])
→ skip

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
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums); // IMPORTANT

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

            // Skip duplicates
            if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                continue;

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