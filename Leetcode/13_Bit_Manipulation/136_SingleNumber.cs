/*
========================================================
LeetCode Problem: 136. Single Number
Pattern: Bit Manipulation (XOR)
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/single-number/

--------------------------------------------------------
Problem Statement

Given a non-empty integer array nums,

Every element appears twice except one.

Return that single number.

Example:

Input:
nums = [4,1,2,1,2]

Output:
4

--------------------------------------------------------
Approach #1 : HashSet (Commented)

Idea:
Count frequency.

Time Complexity:
O(n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #2 : XOR (Optimal)

Idea:

XOR Rules:
a ^ a = 0
a ^ 0 = a

So duplicates cancel out.

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
    Approach #1 : HashSet (Commented)
    ========================================================

    public int SingleNumber(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
                set.Remove(num);
            else
                set.Add(num);
        }

        return set.First();
    }
    */

    /*
    ========================================================
    Approach #2 : XOR (Optimal)
    ========================================================
    */

    public int SingleNumber(int[] nums)
    {
        int result = 0;

        foreach (int num in nums)
        {
            result ^= num;
        }

        return result;
    }
}