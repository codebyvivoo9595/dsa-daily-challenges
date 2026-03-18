/*
========================================================
LeetCode Problem: 125. Valid Palindrome
Pattern: Two Pointers
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/valid-palindrome/

--------------------------------------------------------
Problem Statement

A phrase is a palindrome if, after converting all 
uppercase letters into lowercase letters and removing 
all non-alphanumeric characters, it reads the same 
forward and backward.

Given a string s, return true if it is a palindrome,
or false otherwise.

Example:

Input:
s = "A man, a plan, a canal: Panama"

Output:
true

Input:
s = "race a car"

Output:
false

--------------------------------------------------------
Approach #1 : Reverse String

Idea:
1. Clean string (remove non-alphanumeric)
2. Reverse string
3. Compare with original

Time Complexity:
O(n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #2 : Two Pointers (Optimal)

Idea:
Use two pointers:
- left at start
- right at end

Skip non-alphanumeric characters and compare.

Steps:
1. Initialize left = 0, right = n-1
2. Skip invalid characters
3. Compare characters (case insensitive)
4. Move pointers inward

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
    Approach #1 : Reverse String
    ========================================================

    public bool IsPalindrome(string s)
    {
        string cleaned = "";

        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                cleaned += char.ToLower(c);
            }
        }

        char[] arr = cleaned.ToCharArray();
        Array.Reverse(arr);

        return cleaned == new string(arr);
    }

    */

    // =====================================================
    // Approach #2 : Two Pointers (Optimal)
    // =====================================================

    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Skip non-alphanumeric
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;

            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            // Compare characters
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}