/*
========================================================
LeetCode Problem: 167. Two Sum II - Input Array Is Sorted
Pattern: Two Pointers
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

--------------------------------------------------------
Problem Statement

Given a 1-indexed array of integers numbers that is 
already sorted in non-decreasing order, find two numbers 
such that they add up to a specific target number.

Return the indices (1-based) of the two numbers.

Example:

Input:
numbers = [2,7,11,15], target = 9

Output:
[1,2]

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Check every pair and find sum.

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Two Pointers (Optimal)

Idea:
Since array is sorted:

1. Start with:
   left = 0
   right = n-1

2. Calculate sum:
   sum = numbers[left] + numbers[right]

3. If sum == target → return
4. If sum < target → move left++
5. If sum > target → move right--

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
    Approach #1 : Brute Force
    ========================================================

    public int[] TwoSum(int[] numbers, int target)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if(numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }
            }
        }

        return new int[] { };
    }

    */

    // =====================================================
    // Approach #2 : Two Pointers (Optimal)
    // =====================================================

    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                return new int[] { left + 1, right + 1 }; // 1-based index
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new int[] { };
    }
}