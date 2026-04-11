/*
========================================================
LeetCode Problem: 74. Search a 2D Matrix
Pattern: Binary Search
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/search-a-2d-matrix/

--------------------------------------------------------
Problem Statement

You are given an m x n integer matrix with properties:

1. Each row is sorted in ascending order
2. First element of each row is greater than last of previous row

Given target, return true if it exists.

Example:

Input:
matrix = [
  [1,3,5,7],
  [10,11,16,20],
  [23,30,34,60]
]
target = 3

Output:
true

--------------------------------------------------------
Approach #1 : Brute Force

Check every element.

Time Complexity:
O(m * n)

--------------------------------------------------------
Approach #2 : Binary Search (Flatten Matrix)

Idea:
Treat matrix as a sorted 1D array.

Index Mapping:
row = mid / cols
col = mid % cols

Time Complexity:
O(log(m*n))

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

    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(matrix[i][j] == target)
                    return true;
            }
        }

        return false;
    }

    */

    // =====================================================
    // Approach #2 : Binary Search (Optimal)
    // =====================================================

    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int left = 0;
        int right = m * n - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int row = mid / n;
            int col = mid % n;

            int value = matrix[row][col];

            if (value == target)
            {
                return true;
            }
            else if (value < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}