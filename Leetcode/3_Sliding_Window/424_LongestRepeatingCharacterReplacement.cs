/*
========================================================
LeetCode Problem: 424. Longest Repeating Character Replacement
Pattern: Sliding Window
Difficulty: Medium (Important)

LeetCode Link:
https://leetcode.com/problems/longest-repeating-character-replacement/

--------------------------------------------------------
Problem Statement

You are given a string s and an integer k. You can choose
any character of the string and change it to any other
uppercase English character.

You can perform this operation at most k times.

Return the length of the longest substring containing
the same letter you can get.

Example:

Input:
s = "AABABBA", k = 1

Output:
4

Explanation:
Replace one 'A' → "AABBBBA"
Longest substring = "BBBB" → length = 4

--------------------------------------------------------
Approach : Sliding Window + Frequency Array

Idea:
We want a window where we can make all characters same
by replacing at most k characters.

Key Formula:
window size - maxFreq <= k

Steps:
1. Use frequency array for 26 letters
2. Track max frequency in current window
3. Expand window
4. If invalid → shrink window
5. Track max length

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] freq = new int[26];

        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            // Increase frequency
            freq[s[right] - 'A']++;

            // Track max frequency in window
            maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

            // Check if window is valid
            int windowSize = right - left + 1;

            if (windowSize - maxFreq > k)
            {
                // Shrink window
                freq[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}