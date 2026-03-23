/*
========================================================
LeetCode Problem: 121. Best Time to Buy and Sell Stock
Pattern: Sliding Window
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

--------------------------------------------------------
Problem Statement

You are given an array prices where prices[i] is the 
price of a stock on the ith day.

You want to maximize your profit by choosing a single
day to buy one stock and choosing a different day in
the future to sell that stock.

Return the maximum profit.

Example:

Input:
prices = [7,1,5,3,6,4]

Output:
5

Explanation:
Buy at 1, sell at 6 → profit = 5

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Try every pair of buy and sell days.

Time Complexity:
O(n^2)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Sliding Window (Optimal)

Idea:
Track minimum price so far and calculate profit.

Steps:
1. Keep minPrice
2. Calculate profit = current price - minPrice
3. Update maxProfit

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

    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit;
    }

    */

    // =====================================================
    // Approach #2 : Sliding Window (Optimal)
    // =====================================================

    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                int profit = price - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit;
    }
}