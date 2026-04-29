/*
========================================================
LeetCode Problem: 200. Number of Islands
Pattern: Graphs (DFS / BFS)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/number-of-islands/

--------------------------------------------------------
Problem Statement

Given a 2D grid of '1's (land) and '0's (water),
return the number of islands.

An island is surrounded by water and formed by
connecting adjacent lands (horizontal/vertical).

--------------------------------------------------------
Approach : DFS (Flood Fill)

Idea:
1. Traverse grid
2. When '1' found → start DFS
3. Mark all connected land as visited
4. Increment island count

Time Complexity:
O(m * n)

Space Complexity:
O(m * n) (recursion stack)

========================================================
*/

using System;

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
            return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    DFS(grid, i, j);
                    count++;
                }
            }
        }

        return count;
    }

    private void DFS(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length ||
            grid[i][j] == '0')
            return;

        // Mark visited
        grid[i][j] = '0';

        DFS(grid, i + 1, j);
        DFS(grid, i - 1, j);
        DFS(grid, i, j + 1);
        DFS(grid, i, j - 1);
    }
}