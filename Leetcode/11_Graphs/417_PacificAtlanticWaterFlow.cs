/*
========================================================
LeetCode Problem: 417. Pacific Atlantic Water Flow
Pattern: Graphs (DFS / Reverse Thinking)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/pacific-atlantic-water-flow/

--------------------------------------------------------
Problem Statement

You are given a matrix heights.

Water can flow from a cell to another if:
- Next cell height <= current cell height

Return all cells where water can flow to BOTH:
Pacific Ocean (top, left edges)
Atlantic Ocean (bottom, right edges)

--------------------------------------------------------
Approach : Reverse DFS

Idea:
Instead of checking each cell → go reverse.

1. Start DFS from Pacific borders
2. Start DFS from Atlantic borders
3. Find intersection of reachable cells

Time Complexity:
O(m * n)

Space Complexity:
O(m * n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        int rows = heights.Length;
        int cols = heights[0].Length;

        bool[,] pacific = new bool[rows, cols];
        bool[,] atlantic = new bool[rows, cols];

        // DFS from borders
        for (int i = 0; i < rows; i++)
        {
            DFS(heights, pacific, i, 0);
            DFS(heights, atlantic, i, cols - 1);
        }

        for (int j = 0; j < cols; j++)
        {
            DFS(heights, pacific, 0, j);
            DFS(heights, atlantic, rows - 1, j);
        }

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (pacific[i, j] && atlantic[i, j])
                {
                    result.Add(new List<int> { i, j });
                }
            }
        }

        return result;
    }

    private void DFS(int[][] heights, bool[,] visited, int i, int j)
    {
        visited[i, j] = true;

        int[][] directions = new int[][]
        {
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };

        foreach (var dir in directions)
        {
            int ni = i + dir[0];
            int nj = j + dir[1];

            if (ni >= 0 && nj >= 0 &&
                ni < heights.Length && nj < heights[0].Length &&
                !visited[ni, nj] &&
                heights[ni][nj] >= heights[i][j])
            {
                DFS(heights, visited, ni, nj);
            }
        }
    }
}