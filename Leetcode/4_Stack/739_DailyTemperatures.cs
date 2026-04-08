/*
========================================================
LeetCode Problem: 739. Daily Temperatures
Pattern: Stack (Monotonic Stack)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/daily-temperatures/

--------------------------------------------------------
Problem Statement

Given an array of integers temperatures represents the
daily temperatures, return an array answer such that:

answer[i] = number of days you have to wait after the ith
day to get a warmer temperature.

If there is no future day, keep 0.

Example:

Input:
temperatures = [73,74,75,71,69,72,76,73]

Output:
[1,1,4,2,1,1,0,0]

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
For each day, check next days to find warmer temperature.

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Monotonic Stack (Optimal)

Idea:
Use stack to store indices of decreasing temperatures.

Steps:
1. Traverse array
2. While current temp > stack top temp:
   → pop index
   → calculate days difference
3. Push current index

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

    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] result = new int[n];

        for(int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if(temperatures[j] > temperatures[i])
                {
                    result[i] = j - i;
                    break;
                }
            }
        }

        return result;
    }

    */

    // =====================================================
    // Approach #2 : Monotonic Stack (Optimal)
    // =====================================================

    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] result = new int[n];

        Stack<int> stack = new Stack<int>(); // store indices

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int prevIndex = stack.Pop();
                result[prevIndex] = i - prevIndex;
            }

            stack.Push(i);
        }

        return result;
    }
}