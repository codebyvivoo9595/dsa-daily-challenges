/*
========================================================
LeetCode Problem: 131. Palindrome Partitioning
Pattern: Backtracking (Partitioning)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/palindrome-partitioning/

--------------------------------------------------------
Problem Statement

Given a string s, partition s such that every substring
of the partition is a palindrome.

Return all possible palindrome partitioning.

Example:

Input:
s = "aab"

Output:
[
 ["a","a","b"],
 ["aa","b"]
]

--------------------------------------------------------
Approach : Backtracking + Palindrome Check

Idea:
Try every possible partition and check if substring
is palindrome.

Steps:
1. Loop over substring
2. If palindrome → choose
3. Recurse for remaining string
4. Backtrack

Time Complexity:
O(n * 2^n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();
        List<string> current = new List<string>();

        Backtrack(s, 0, current, result);

        return result;
    }

    private void Backtrack(string s, int start, List<string> current, IList<IList<string>> result)
    {
        if (start == s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }

        for (int end = start; end < s.Length; end++)
        {
            if (IsPalindrome(s, start, end))
            {
                // Choose
                current.Add(s.Substring(start, end - start + 1));

                // Explore
                Backtrack(s, end + 1, current, result);

                // Backtrack
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}