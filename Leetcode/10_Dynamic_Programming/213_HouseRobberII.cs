/*
========================================================
LeetCode Problem: 213. House Robber II
Pattern: Dynamic Programming (1D DP)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/house-robber-ii/

--------------------------------------------------------
Problem Statement

Same as House Robber, but houses are in a circle.

That means:
- First and last house are adjacent ❌

Return maximum money you can rob.

Example:

Input:
nums = [2,3,2]

Output:
3

--------------------------------------------------------
Approach : Break into 2 cases

Idea:
We cannot take both first and last house.

So:
Case 1 → Rob from index 0 to n-2
Case 2 → Rob from index 1 to n-1

Take max of both cases.

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];

        // Case 1: exclude last
        int case1 = RobLinear(nums, 0, nums.Length - 2);

        // Case 2: exclude first
        int case2 = RobLinear(nums, 1, nums.Length - 1);

        return Math.Max(case1, case2);
    }

    private int RobLinear(int[] nums, int start, int end)
    {
        int prev2 = 0;
        int prev1 = 0;

        for (int i = start; i <= end; i++)
        {
            int pick = nums[i] + prev2;
            int skip = prev1;

            int current = Math.Max(pick, skip);

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}