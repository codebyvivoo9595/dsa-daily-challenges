/*
========================================================
LeetCode Problem: 1. Two Sum
Pattern: Arrays / HashMap
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/two-sum/

--------------------------------------------------------
Problem Statement

Given an array of integers nums and an integer target,
return indices of the two numbers such that they add up
to target.

Example:

Input:
nums = [2,7,11,15]
target = 9

Output:
[0,1]

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Check every pair of numbers and see if their sum equals
the target.

Steps:
1. Use two loops
2. Compare nums[i] + nums[j]
3. If equal to target return indices

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : HashMap (Optimal)

Idea:
Store numbers in dictionary while traversing.

Check if (target - current number) already exists.

Example:
nums = [2,7,11,15], target = 9

i=0 → num=2 → store {2:0}

i=1 → num=7
target-7 = 2 → exists → return [0,1]

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
    
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { };
    }
    
    */

    // ======================================================
    // Approach #2 : HashMap (Optimal)
    // ======================================================

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}