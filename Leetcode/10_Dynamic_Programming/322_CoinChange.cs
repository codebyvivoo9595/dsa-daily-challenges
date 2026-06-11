/*
========================================================
LeetCode Problem: 322. Coin Change
Pattern: Dynamic Programming (1D DP)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/coin-change/

--------------------------------------------------------
Problem Statement

You are given an array of coins and an amount.

Return the fewest number of coins needed to make up that amount.

If not possible, return -1.

Example:

Input:
coins = [1,2,5], amount = 11

Output:
3

Explanation:
11 = 5 + 5 + 1

--------------------------------------------------------
Approach : DP (Bottom-Up)

Idea:
dp[i] = minimum coins needed to make amount i

Initialize:
dp[0] = 0  
dp[i] = infinity (for others)

Transition:
dp[i] = min(dp[i], 1 + dp[i - coin])

Time Complexity:
O(n * amount)

Space Complexity:
O(amount)

========================================================
*/

using System;

public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];

        // Initialize with large value
        for (int i = 1; i <= amount; i++)
        {
            dp[i] = amount + 1;
        }

        dp[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (i - coin >= 0)
                {
                    dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
                }
            }
        }

        return dp[amount] == amount + 1 ? -1 : dp[amount];
    }
}