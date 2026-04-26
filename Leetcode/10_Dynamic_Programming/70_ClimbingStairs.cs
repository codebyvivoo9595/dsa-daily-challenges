/*
========================================================
LeetCode Problem: 70. Climbing Stairs
Pattern: Dynamic Programming (1D DP)
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/climbing-stairs/

--------------------------------------------------------
Problem Statement

You are climbing a staircase. It takes n steps to reach the top.

Each time you can climb:
- 1 step
- 2 steps

Return number of distinct ways to reach top.

Example:

Input:
n = 3

Output:
3

Explanation:
1+1+1
1+2
2+1

--------------------------------------------------------
Approach #1 : Recursion (Brute Force)

f(n) = f(n-1) + f(n-2)

Time Complexity:
O(2^n)

--------------------------------------------------------
Approach #2 : DP (Bottom-Up)

Idea:
Store previous results

dp[i] = dp[i-1] + dp[i-2]

Time Complexity:
O(n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #3 : Space Optimized

Only keep last 2 values

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
    Approach #3 : Space Optimized
    ========================================================
    */

    public int ClimbStairs(int n)
    {
        if (n <= 2)
            return n;

        int prev1 = 2;
        int prev2 = 1;

        for (int i = 3; i <= n; i++)
        {
            int current = prev1 + prev2;

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}