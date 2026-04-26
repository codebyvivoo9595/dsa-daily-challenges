/*
========================================================
LeetCode Problem: 40. Combination Sum II
Pattern: Backtracking
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/combination-sum-ii/

--------------------------------------------------------
Problem Statement

Given a collection of candidate numbers (candidates) 
and a target number (target), find all unique combinations 
where the numbers sum to target.

Each number may be used only once.

The solution set must not contain duplicate combinations.

Example:

Input:
candidates = [10,1,2,7,6,1,5], target = 8

Output:
[
 [1,1,6],
 [1,2,5],
 [1,7],
 [2,6]
]

--------------------------------------------------------
Approach : Backtracking + Sorting

Idea:
1. Sort array
2. Skip duplicates
3. Move to next index (no reuse)

Time Complexity:
Exponential

Space Complexity:
O(target)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates); // IMPORTANT

        IList<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();

        Backtrack(candidates, target, 0, current, result);

        return result;
    }

    private void Backtrack(int[] candidates, int target, int index, List<int> current, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        if (target < 0)
            return;

        for (int i = index; i < candidates.Length; i++)
        {
            // Skip duplicates
            if (i > index && candidates[i] == candidates[i - 1])
                continue;

            // Choose
            current.Add(candidates[i]);

            // Explore (move to next index → no reuse)
            Backtrack(candidates, target - candidates[i], i + 1, current, result);

            // Backtrack
            current.RemoveAt(current.Count - 1);
        }
    }
}