/*
========================================================
LeetCode Problem: 134. Gas Station
Pattern: Greedy
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/gas-station/

--------------------------------------------------------
Problem Statement

There are n gas stations.

gas[i] = gas available
cost[i] = gas needed to travel to next station

Return starting station index if possible to
complete full circuit.

Otherwise return -1.

--------------------------------------------------------
Approach : Greedy

Idea:
1. If total gas < total cost → impossible
2. Track current tank
3. If tank becomes negative:
   - current start impossible
   - move start to next station
   - reset tank

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int totalGas = 0;
        int totalCost = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            totalGas += gas[i];
            totalCost += cost[i];
        }

        // Impossible overall
        if (totalGas < totalCost)
            return -1;

        int tank = 0;
        int start = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            tank += gas[i] - cost[i];

            // Cannot continue
            if (tank < 0)
            {
                start = i + 1;
                tank = 0;
            }
        }

        return start;
    }
}