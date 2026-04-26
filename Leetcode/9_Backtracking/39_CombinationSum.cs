/*
========================================================
LeetCode Problem: 39. Combination Sum
Pattern: Backtracking
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/combination-sum/

--------------------------------------------------------
Problem Statement

Given an array of distinct integers candidates and a target,
return all unique combinations where the numbers sum to target.

You can use the same number unlimited times.

Example:

Input:
candidates = [2,3,6,7], target = 7

Output:
[
 [2,2,3],
 [7]
]

--------------------------------------------------------
Approach : Backtracking

Idea:
At each step:
- Choose current number
- Stay at same index (reuse allowed)

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
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
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
            // Choose
            current.Add(candidates[i]);

            // Explore (stay at same index)
            Backtrack(candidates, target - candidates[i], i, current, result);

            // Backtrack
            current.RemoveAt(current.Count - 1);
        }
    }
}