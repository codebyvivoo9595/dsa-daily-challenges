/*
========================================================
LeetCode Problem: 746. Min Cost Climbing Stairs
Pattern: Dynamic Programming (1D DP)
Difficulty: Easy-Medium

LeetCode Link:
https://leetcode.com/problems/min-cost-climbing-stairs/

--------------------------------------------------------
Problem Statement

You are given an array cost where cost[i] is the cost
of ith step.

You can start from step 0 or 1.

Each time you can climb:
- 1 step
- 2 steps

Return minimum cost to reach the top.

Example:

Input:
cost = [10,15,20]

Output:
15

Explanation:
Start at index 1 → pay 15 → reach top

--------------------------------------------------------
Approach : DP (Space Optimized)

Idea:
dp[i] = cost[i] + min(dp[i-1], dp[i-2])

We only need last 2 values.

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int prev2 = cost[0];
        int prev1 = cost[1];

        for (int i = 2; i < cost.Length; i++)
        {
            int current = cost[i] + Math.Min(prev1, prev2);

            prev2 = prev1;
            prev1 = current;
        }

        return Math.Min(prev1, prev2);
    }
}