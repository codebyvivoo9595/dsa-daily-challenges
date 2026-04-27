/*
========================================================
LeetCode Problem: 198. House Robber
Pattern: Dynamic Programming (1D DP)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/house-robber/

--------------------------------------------------------
Problem Statement

You are a robber planning to rob houses along a street.

Each house has some money, but you cannot rob two
adjacent houses.

Return the maximum amount you can rob.

Example:

Input:
nums = [2,7,9,3,1]

Output:
12

Explanation:
Rob house 1 (2) + house 3 (9) + house 5 (1) = 12

--------------------------------------------------------
Approach : DP (Pick / Skip)

Idea:
At each house → decide:
1. Pick → nums[i] + dp[i-2]
2. Skip → dp[i-1]

dp[i] = max(pick, skip)

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

        int prev2 = 0;        // dp[i-2]
        int prev1 = 0;        // dp[i-1]

        foreach (int num in nums)
        {
            int pick = num + prev2;
            int skip = prev1;

            int current = Math.Max(pick, skip);

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}