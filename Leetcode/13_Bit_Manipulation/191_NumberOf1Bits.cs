/*
========================================================
LeetCode Problem: 191. Number of 1 Bits
Pattern: Bit Manipulation
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/number-of-1-bits/

--------------------------------------------------------
Problem Statement

Given a positive integer n,

Return number of '1' bits
(Hamming Weight).

Example:

Input:
n = 11

Output:
3

Explanation:
11 = 1011

--------------------------------------------------------
Approach #1 : Bit Shift

Idea:
Check last bit and shift.

Time Complexity:
O(32)

--------------------------------------------------------
Approach #2 : Brian Kernighan Algorithm (Optimal)

Idea:
n & (n - 1)

Removes rightmost set bit.

Time Complexity:
O(number of set bits)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    /*
    ========================================================
    Approach #1 : Bit Shift (Commented)
    ========================================================

    public int HammingWeight(uint n)
    {
        int count = 0;

        while (n > 0)
        {
            count += (int)(n & 1);
            n >>= 1;
        }

        return count;
    }
    */

    /*
    ========================================================
    Approach #2 : Brian Kernighan
    ========================================================
    */

    public int HammingWeight(uint n)
    {
        int count = 0;

        while (n != 0)
        {
            n = n & (n - 1);
            count++;
        }

        return count;
    }
}