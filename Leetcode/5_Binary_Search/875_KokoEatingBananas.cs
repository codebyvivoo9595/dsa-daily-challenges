/*
========================================================
LeetCode Problem: 875. Koko Eating Bananas
Pattern: Binary Search on Answer
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/koko-eating-bananas/

--------------------------------------------------------
Problem Statement

Koko loves to eat bananas. There are piles of bananas.

Given:
- piles[] → number of bananas
- h → hours

Koko can eat at most k bananas per hour.

Return the minimum k such that she can finish all bananas
within h hours.

Example:

Input:
piles = [3,6,7,11], h = 8

Output:
4

--------------------------------------------------------
Approach : Binary Search on Answer

Idea:
We are NOT searching index.
We are searching minimum "k" (eating speed).

Steps:
1. Define search space:
   low = 1
   high = max(piles)

2. Binary search on k

3. For each k:
   calculate total hours required

4. If hours <= h → valid → try smaller k
   else → increase k

Time Complexity:
O(n log max(piles))

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = GetMax(piles);

        int result = right;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int hours = CalculateHours(piles, mid);

            if (hours <= h)
            {
                result = mid;
                right = mid - 1; // try smaller speed
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }

    private int CalculateHours(int[] piles, int k)
    {
        int totalHours = 0;

        foreach (int pile in piles)
        {
            // Ceiling division
            totalHours += (pile + k - 1) / k;
        }

        return totalHours;
    }

    private int GetMax(int[] piles)
    {
        int max = 0;
        foreach (int p in piles)
        {
            if (p > max)
                max = p;
        }
        return max;
    }
}