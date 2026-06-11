/*
========================================================
LeetCode Problem: 1899. Merge Triplets to Form Target Triplet
Pattern: Greedy
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/merge-triplets-to-form-target-triplet/

--------------------------------------------------------
Problem Statement

You are given triplets and a target triplet.

Operation:
Choose two triplets and merge them.

Merged value:
max(a1,a2), max(b1,b2), max(c1,c2)

Return true if target can be formed.

Example:

Input:
triplets = [[2,5,3],[1,8,4],[1,7,5]]
target = [2,7,5]

Output:
true

--------------------------------------------------------
Approach : Greedy

Idea:
1. Ignore invalid triplets
   (any value > target)
2. Track matched target positions
3. If all matched → true

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public bool MergeTriplets(int[][] triplets, int[] target)
    {
        bool matchA = false;
        bool matchB = false;
        bool matchC = false;

        foreach (var triplet in triplets)
        {
            // Ignore invalid
            if (triplet[0] > target[0] ||
                triplet[1] > target[1] ||
                triplet[2] > target[2])
                continue;

            if (triplet[0] == target[0])
                matchA = true;

            if (triplet[1] == target[1])
                matchB = true;

            if (triplet[2] == target[2])
                matchC = true;
        }

        return matchA && matchB && matchC;
    }
}