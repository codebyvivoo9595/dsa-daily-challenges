/*
========================================================
LeetCode Problem: 1011. Capacity To Ship Packages Within D Days
Pattern: Binary Search on Answer
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/

--------------------------------------------------------
Problem Statement

You are given an array weights where weights[i] is the 
weight of a package.

You need to ship packages within D days.

Each day:
- You load packages in order
- Total weight ≤ ship capacity

Return the minimum ship capacity to deliver all packages
within D days.

Example:

Input:
weights = [1,2,3,4,5,6,7,8,9,10], D = 5

Output:
15

--------------------------------------------------------
Approach : Binary Search on Answer

Idea:
We are searching minimum capacity.

Steps:
1. Search space:
   left = max(weights)  (must carry largest)
   right = sum(weights) (carry all in one day)

2. For each capacity:
   check how many days needed

3. If days <= D → valid → try smaller capacity
   else → increase capacity

Time Complexity:
O(n log sum)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int left = GetMax(weights);
        int right = GetSum(weights);

        int result = right;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int requiredDays = CalculateDays(weights, mid);

            if (requiredDays <= days)
            {
                result = mid;
                right = mid - 1; // try smaller capacity
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }

    private int CalculateDays(int[] weights, int capacity)
    {
        int days = 1;
        int currentLoad = 0;

        foreach (int weight in weights)
        {
            if (currentLoad + weight > capacity)
            {
                days++;
                currentLoad = 0;
            }

            currentLoad += weight;
        }

        return days;
    }

    private int GetMax(int[] weights)
    {
        int max = 0;
        foreach (int w in weights)
        {
            if (w > max)
                max = w;
        }
        return max;
    }

    private int GetSum(int[] weights)
    {
        int sum = 0;
        foreach (int w in weights)
        {
            sum += w;
        }
        return sum;
    }
}