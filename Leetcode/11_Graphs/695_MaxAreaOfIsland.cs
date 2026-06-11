/*
========================================================
LeetCode Problem: 695. Max Area of Island
Pattern: Graphs (DFS / Flood Fill)
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/max-area-of-island/

--------------------------------------------------------
Problem Statement

Given a 2D grid of 0's (water) and 1's (land),
return the maximum area of an island.

An island is formed by connected 1's (4-directionally).

--------------------------------------------------------
Approach : DFS (Flood Fill)

Idea:
1. Traverse grid
2. When '1' found → start DFS
3. Count size of that island
4. Track max area

Time Complexity:
O(m * n)

Space Complexity:
O(m * n)

========================================================
*/

using System;

public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int maxArea = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    int area = DFS(grid, i, j);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }

        return maxArea;
    }

    private int DFS(int[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length ||
            grid[i][j] == 0)
            return 0;

        // Mark visited
        grid[i][j] = 0;

        int area = 1;

        area += DFS(grid, i + 1, j);
        area += DFS(grid, i - 1, j);
        area += DFS(grid, i, j + 1);
        area += DFS(grid, i, j - 1);

        return area;
    }
}