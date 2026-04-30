/*
========================================================
LeetCode Problem: 994. Rotting Oranges
Pattern: Graphs (BFS - Multi Source)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/rotting-oranges/

--------------------------------------------------------
Problem Statement

You are given a grid where:
0 → empty
1 → fresh orange
2 → rotten orange

Every minute, rotten oranges spread to adjacent fresh ones.

Return minimum time required to rot all oranges.
If impossible → return -1.

--------------------------------------------------------
Approach : BFS (Multi-Source)

Idea:
1. Add all rotten oranges to queue (starting points)
2. Perform BFS level by level (each level = 1 minute)
3. Spread rot to fresh oranges
4. Count fresh oranges

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
    public int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int, int)> queue = new Queue<(int, int)>();
        int fresh = 0;

        // Step 1: Initialize queue and count fresh
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 2)
                    queue.Enqueue((i, j));
                else if (grid[i][j] == 1)
                    fresh++;
            }
        }

        int minutes = 0;
        int[][] directions = new int[][]
        {
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };

        // Step 2: BFS
        while (queue.Count > 0 && fresh > 0)
        {
            int size = queue.Count;
            minutes++;

            for (int i = 0; i < size; i++)
            {
                var (r, c) = queue.Dequeue();

                foreach (var dir in directions)
                {
                    int nr = r + dir[0];
                    int nc = c + dir[1];

                    if (nr >= 0 && nc >= 0 && nr < rows && nc < cols &&
                        grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        queue.Enqueue((nr, nc));
                        fresh--;
                    }
                }
            }
        }

        return fresh == 0 ? minutes : -1;
    }
}