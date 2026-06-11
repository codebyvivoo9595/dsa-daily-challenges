/*
========================================================
LeetCode Problem: 647. Palindromic Substrings
Pattern: Expand Around Center
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/palindromic-substrings/

--------------------------------------------------------
Problem Statement

Given a string s, return the number of palindromic substrings.

Example:

Input:
s = "aaa"

Output:
6

Explanation:
"a", "a", "a", "aa", "aa", "aaa"

--------------------------------------------------------
Approach : Expand Around Center

Idea:
Same as previous problem (#5), but instead of tracking
longest → count every valid palindrome.

Time Complexity:
O(n^2)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int CountSubstrings(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // Odd length
            count += Expand(s, i, i);

            // Even length
            count += Expand(s, i, i + 1);
        }

        return count;
    }

    private int Expand(string s, int left, int right)
    {
        int count = 0;

        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            count++; // valid palindrome found
            left--;
            right++;
        }

        return count;
    }
}