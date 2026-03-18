/*
========================================================
LeetCode Problem: 11. Container With Most Water
Pattern: Two Pointers
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/container-with-most-water/

--------------------------------------------------------
Problem Statement

You are given an integer array height where each element
represents the height of a vertical line.

Find two lines that together with the x-axis form a
container that holds the most water.

Return the maximum amount of water.

Example:

Input:
height = [1,8,6,2,5,4,8,3,7]

Output:
49

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Check all pairs and calculate area.

Area = min(height[i], height[j]) * (j - i)

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Two Pointers (Optimal)

Idea:
1. Start with left = 0, right = n-1
2. Calculate area
3. Move pointer with smaller height

Why?
Because area depends on min height,
so increasing smaller height may improve result.

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

    public int MaxArea(int[] height)
    {
        int maxArea = 0;

        for(int i = 0; i < height.Length; i++)
        {
            for(int j = i + 1; j < height.Length; j++)
            {
                int h = Math.Min(height[i], height[j]);
                int w = j - i;

                int area = h * w;

                maxArea = Math.Max(maxArea, area);
            }
        }

        return maxArea;
    }

    */

    // =====================================================
    // Approach #2 : Two Pointers (Optimal)
    // =====================================================

    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;

            int area = h * w;
            maxArea = Math.Max(maxArea, area);

            // Move the smaller height
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}