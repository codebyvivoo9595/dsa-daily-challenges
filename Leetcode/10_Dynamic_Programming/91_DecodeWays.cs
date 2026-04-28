/*
========================================================
LeetCode Problem: 91. Decode Ways
Pattern: Dynamic Programming (1D DP)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/decode-ways/

--------------------------------------------------------
Problem Statement

A message containing digits is decoded as:

'A' -> 1
'B' -> 2
...
'Z' -> 26

Given a string s, return number of ways to decode it.

Example:

Input:
s = "226"

Output:
3

Explanation:
"2 2 6" -> BBF
"22 6" -> VF
"2 26" -> BZ

--------------------------------------------------------
Approach : DP (Bottom-Up)

Idea:
At each position:
- Take single digit (if valid)
- Take two digits (if valid)

dp[i] = ways to decode till index i

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;

        int prev2 = 1; // dp[i-2]
        int prev1 = 1; // dp[i-1]

        for (int i = 1; i < s.Length; i++)
        {
            int current = 0;

            // Single digit
            if (s[i] != '0')
                current += prev1;

            // Two digits
            int twoDigit = (s[i - 1] - '0') * 10 + (s[i] - '0');

            if (twoDigit >= 10 && twoDigit <= 26)
                current += prev2;

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}