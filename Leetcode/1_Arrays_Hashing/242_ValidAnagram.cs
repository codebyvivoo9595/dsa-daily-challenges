/*
========================================================
LeetCode Problem: 242. Valid Anagram
Pattern: Arrays / Hashing
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/valid-anagram/

--------------------------------------------------------
Problem Statement

Given two strings s and t, return true if t is an
anagram of s, and false otherwise.

An Anagram is a word formed by rearranging the
letters of another word using all the original letters
exactly once.

Example 1:

Input:
s = "anagram"
t = "nagaram"

Output:
true

Example 2:

Input:
s = "rat"
t = "car"

Output:
false

--------------------------------------------------------
Approach #1 : Sorting

Idea:
If two strings are anagrams, their sorted version
will be identical.

Steps:
1. Convert string to char array
2. Sort both arrays
3. Compare sorted strings

Time Complexity:
O(n log n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #2 : HashMap (Character Frequency)

Idea:
Count frequency of each character in both strings.

If frequency matches → anagram.

Steps:
1. If lengths are different → return false
2. Use dictionary to count characters
3. Increment for s
4. Decrement for t
5. If any count != 0 → not anagram

Time Complexity:
O(n)

Space Complexity:
O(1)  (only 26 lowercase letters)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{

    /*
    ========================================================
    Approach #1 : Sorting
    ========================================================

    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }

    */

    
     // =====================================================
    // Approach #3 : 
    // =====================================================

     /*
     public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            // If lengths don't match, not an anagram
            return false;
        }

        // Create array to count frequency of characters
        int[] charFreq = new int[26]; // English lowercase letters

        // Increment for each character in 's' and decrement for each in 't'
        for (int i = 0; i < s.Length; i++)
        {
            charFreq[s[i] - 'a']++;
            charFreq[t[i] - 'a']--;
        }

        // Check if all counts are zero
        foreach (int count in charFreq)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true; // All counts are zero → anagrams

    }
   }
     
     */


    // =====================================================
    // Approach #2 : HashMap (Optimal)
    // =====================================================

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }

        foreach (char c in t)
        {
            if (!map.ContainsKey(c))
                return false;

            map[c]--;

            if (map[c] == 0)
                map.Remove(c);
        }

        return map.Count == 0;
    }
}