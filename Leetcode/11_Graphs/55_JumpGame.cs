/*
========================================================
LeetCode Problem: 55. Jump Game
Pattern: Greedy
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/jump-game/

--------------------------------------------------------
Problem Statement

You are given an integer array nums.

Each element represents maximum jump length.

Return true if you can reach last index.

Example:

Input:
nums = [2,3,1,1,4]

Output:
true

Explanation:
0 -> 1 -> 4

--------------------------------------------------------
Approach #1 : DP (Commented)

Idea:
Try all reachable positions.

Time Complexity:
O(n^2)

--------------------------------------------------------
Approach #2 : Greedy (Optimal)

Idea:
Track farthest reachable index.

If current index > farthest → impossible.

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    /*
    ========================================================
    Approach #1 : DP (Commented)
    ========================================================

    public bool CanJump(int[] nums)
    {
        bool[] dp = new bool[nums.Length];
        dp[0] = true;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dp[i])
                continue;

            for (int j = 1; j <= nums[i] && i + j < nums.Length; j++)
            {
                dp[i + j] = true;
            }
        }

        return dp[nums.Length - 1];
    }
    */

    /*
    ========================================================
    Approach #2 : Greedy (Optimal)
    ========================================================
    */

    public bool CanJump(int[] nums)
    {
        int farthest = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > farthest)
                return false;

            farthest = Math.Max(farthest, i + nums[i]);
        }

        return true;
    }
}