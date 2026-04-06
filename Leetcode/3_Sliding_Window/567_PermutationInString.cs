/*
========================================================
LeetCode Problem: 567. Permutation in String
Pattern: Sliding Window
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/permutation-in-string/

--------------------------------------------------------
Problem Statement

Given two strings s1 and s2, return true if s2 contains
a permutation of s1.

In other words, check if one of s1's permutations is
a substring of s2.

Example:

Input:
s1 = "ab", s2 = "eidbaooo"

Output:
true

Explanation:
"ba" is a permutation of "ab"

--------------------------------------------------------
Approach : Sliding Window + Frequency Array

Idea:
We check if any substring of s2 has the same frequency
as s1.

Steps:
1. Create frequency array for s1
2. Use sliding window of size s1.Length on s2
3. Maintain frequency array for window
4. Compare both arrays

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        int[] s1Freq = new int[26];
        int[] windowFreq = new int[26];

        // Frequency of s1
        foreach (char c in s1)
        {
            s1Freq[c - 'a']++;
        }

        int windowSize = s1.Length;

        for (int i = 0; i < s2.Length; i++)
        {
            // Add current character to window
            windowFreq[s2[i] - 'a']++;

            // Remove character if window exceeds size
            if (i >= windowSize)
            {
                windowFreq[s2[i - windowSize] - 'a']--;
            }

            // Compare arrays
            if (AreEqual(s1Freq, windowFreq))
            {
                return true;
            }
        }

        return false;
    }

    private bool AreEqual(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }
}