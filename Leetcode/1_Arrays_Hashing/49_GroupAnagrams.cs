/*
========================================================
LeetCode Problem: 49. Group Anagrams
Pattern: Arrays / Hashing
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/group-anagrams/

--------------------------------------------------------
Problem Statement

Given an array of strings strs, group the anagrams
together. You can return the answer in any order.

Example:

Input:
strs = ["eat","tea","tan","ate","nat","bat"]

Output:
[["eat","tea","ate"],["tan","nat"],["bat"]]

--------------------------------------------------------
Approach #1 : Sorting Key

Idea:
If two strings are anagrams, their sorted form will
be the same.

Use sorted string as key in dictionary.

Steps:
1. Iterate through each string
2. Sort characters of string
3. Use sorted string as key
4. Group original strings in dictionary

Time Complexity:
O(n * k log k)
n = number of strings
k = max length of string

Space Complexity:
O(n * k)

--------------------------------------------------------
Approach #2 : Character Count Key (Optimal)

Idea:
Instead of sorting, use character frequency as key.

Example:
"eat" → count of a-z → "1#0#0#...#1#..."

This avoids sorting cost.

Time Complexity:
O(n * k)

Space Complexity:
O(n * k)

========================================================
*/

using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    /*
    ========================================================
    Approach #1 : Sorting Key
    ========================================================

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if(!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(str);
        }

        return new List<IList<string>>(map.Values);
    }

    */

    // =====================================================
    // Approach #2 : Character Count Key (Optimal)
    // =====================================================

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            int[] count = new int[26];

            foreach (char c in str)
            {
                count[c - 'a']++;
            }

            // Build key
            StringBuilder keyBuilder = new StringBuilder();

            foreach (int num in count)
            {
                keyBuilder.Append(num);
                keyBuilder.Append('#'); // separator
            }

            string key = keyBuilder.ToString();

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(str);
        }

        return new List<IList<string>>(map.Values);
    }
}