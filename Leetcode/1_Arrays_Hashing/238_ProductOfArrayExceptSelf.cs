/*
========================================================
LeetCode Problem: 238. Product of Array Except Self
Pattern: Arrays / Prefix-Suffix
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/product-of-array-except-self/

--------------------------------------------------------
Problem Statement

Given an integer array nums, return an array answer
such that:

answer[i] = product of all elements of nums except nums[i]

Constraints:
- Do NOT use division
- Solve in O(n) time

Example:

Input:
nums = [1,2,3,4]

Output:
[24,12,8,6]

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
For each element, multiply all other elements.

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Prefix + Suffix Arrays

Idea:
1. prefix[i] = product of elements before i
2. suffix[i] = product of elements after i

answer[i] = prefix[i] * suffix[i]

Time Complexity:
O(n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #3 : Optimized (No Extra Space)

Idea:
Use result array to store prefix products first,
then multiply with suffix in reverse traversal.

Steps:
1. Build prefix in result[]
2. Traverse from right while maintaining suffix
3. Multiply result[i] with suffix

Time Complexity:
O(n)

Space Complexity:
O(1) (excluding output array)

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

    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        for(int i = 0; i < n; i++)
        {
            int product = 1;

            for(int j = 0; j < n; j++)
            {
                if(i != j)
                {
                    product *= nums[j];
                }
            }

            result[i] = product;
        }

        return result;
    }

    */

    /*
    ========================================================
    Approach #2 : Prefix + Suffix Arrays
    ========================================================

    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] prefix = new int[n];
        int[] suffix = new int[n];
        int[] result = new int[n];

        prefix[0] = 1;
        for(int i = 1; i < n; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        suffix[n - 1] = 1;
        for(int i = n - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < n; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }

    */

    // =====================================================
    // Approach #3 : Optimized (Best)
    // =====================================================

    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        // Step 1: Prefix product
        result[0] = 1;
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        // Step 2: Suffix product
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }
}