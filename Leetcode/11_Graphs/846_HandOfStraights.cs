/*
========================================================
LeetCode Problem: 846. Hand of Straights
Pattern: Greedy + HashMap + Sorting
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/hand-of-straights/

--------------------------------------------------------
Problem Statement

You are given:
hand = cards
groupSize = size of each group

Return true if cards can be rearranged into
groups of consecutive cards.

Example:

Input:
hand = [1,2,3,6,2,3,4,7,8]
groupSize = 3

Output:
true

Explanation:
[1,2,3] [2,3,4] [6,7,8]

--------------------------------------------------------
Approach : Greedy + Frequency Map

Idea:
1. Count frequency of cards
2. Sort cards
3. Always start from smallest available card
4. Build consecutive sequence

Time Complexity:
O(n log n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
            return false;

        Dictionary<int, int> count = new Dictionary<int, int>();

        // Frequency map
        foreach (int card in hand)
        {
            if (!count.ContainsKey(card))
                count[card] = 0;

            count[card]++;
        }

        Array.Sort(hand);

        foreach (int card in hand)
        {
            if (count[card] == 0)
                continue;

            // Build group
            for (int i = 0; i < groupSize; i++)
            {
                int current = card + i;

                if (!count.ContainsKey(current) || count[current] == 0)
                    return false;

                count[current]--;
            }
        }

        return true;
    }
}