/*
========================================================
LeetCode Problem: 5. Longest Palindromic Substring
Pattern: Dynamic Programming / Expand Around Center
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/longest-palindromic-substring/

--------------------------------------------------------
Problem Statement

Given a string s, return the longest palindromic substring.

Example:

Input:
s = "babad"

Output:
"bab" (or "aba")

--------------------------------------------------------
Approach #1 : Brute Force

Check all substrings → O(n^3)

--------------------------------------------------------
Approach #2 : Expand Around Center (Optimal)

Idea:
Every palindrome expands from center.

Steps:
1. Treat each index as center
2. Expand for:
   - odd length (i, i)
   - even length (i, i+1)
3. Track max length

Time Complexity:
O(n^2)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // Odd length
            Expand(s, i, i, ref start, ref maxLength);

            // Even length
            Expand(s, i, i + 1, ref start, ref maxLength);
        }

        return s.Substring(start, maxLength);
    }

    private void Expand(string s, int left, int right, ref int start, ref int maxLength)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            int length = right - left + 1;

            if (length > maxLength)
            {
                start = left;
                maxLength = length;
            }

            left--;
            right++;
        }
    }
}