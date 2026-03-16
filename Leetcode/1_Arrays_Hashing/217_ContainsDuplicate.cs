/*
========================================================
LeetCode Problem: 217. Contains Duplicate
Pattern: Arrays / Hashing
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/contains-duplicate/

--------------------------------------------------------
Problem Statement

Given an integer array nums, return true if any value 
appears at least twice in the array, and return false 
if every element is distinct.

Example 1:

Input:
nums = [1,2,3,1]

Output:
true

Example 2:

Input:
nums = [1,2,3,4]

Output:
false

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Compare every element with every other element.

Steps:
1. Use two nested loops
2. Compare nums[i] with nums[j]
3. If equal return true

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : HashSet (Optimal)

Idea:
Use HashSet to store visited elements.

If element already exists in HashSet → duplicate found.

Steps:
1. Create HashSet
2. Traverse array
3. If element already exists → return true
4. Otherwise add element

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

    public bool ContainsDuplicate(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    */

    // =====================================================
    // Approach #2 : HashSet (Optimal)
    // =====================================================

    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach(int num in nums)
        {
            if(set.Contains(num))
            {
                return true;
            }

            set.Add(num);
        }

        return false;
    }
}