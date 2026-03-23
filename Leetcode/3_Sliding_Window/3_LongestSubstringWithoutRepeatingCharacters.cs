/*
========================================================
LeetCode Problem: 3. Longest Substring Without Repeating Characters
Pattern: Sliding Window
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/longest-substring-without-repeating-characters/

--------------------------------------------------------
Problem Statement

Given a string s, find the length of the longest substring
without repeating characters.

Example:

Input:
s = "abcabcbb"

Output:
3

Explanation:
"abc" is the longest substring without repeating characters.

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Check all substrings and ensure no duplicates.

Time Complexity:
O(n^3)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #2 : Sliding Window + HashSet

Idea:
Use two pointers and maintain a set of unique characters.

Steps:
1. Use left and right pointers
2. Expand window (right++)
3. If duplicate found → shrink window (left++)
4. Track max length

Time Complexity:
O(n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    /*
    ========================================================
    Approach #1 : Brute Force
    ========================================================

    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;

        for(int i = 0; i < s.Length; i++)
        {
            HashSet<char> set = new HashSet<char>();

            for(int j = i; j < s.Length; j++)
            {
                if(set.Contains(s[j]))
                    break;

                set.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
            }
        }

        return maxLength;
    }

    */

    // =====================================================
    // Approach #2 : Sliding Window (Optimal)
    // =====================================================

    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();

        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}