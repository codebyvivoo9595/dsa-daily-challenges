/*
========================================================
LeetCode Problem: 130. Surrounded Regions
Pattern: Graphs (DFS / Boundary Traversal)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/surrounded-regions/

--------------------------------------------------------
Problem Statement

Given a 2D board containing 'X' and 'O',
capture all regions surrounded by 'X'.

A region is captured if it is completely surrounded.

--------------------------------------------------------
Approach : Boundary DFS

Idea:
1. 'O' connected to boundary → cannot be flipped
2. Mark boundary-connected 'O' as safe
3. Flip remaining 'O' → 'X'
4. Restore safe ones

Time Complexity:
O(m * n)

Space Complexity:
O(m * n)

========================================================
*/

using System;

public class Solution
{
    public void Solve(char[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        // Step 1: Mark boundary-connected 'O'
        for (int i = 0; i < rows; i++)
        {
            DFS(board, i, 0);
            DFS(board, i, cols - 1);
        }

        for (int j = 0; j < cols; j++)
        {
            DFS(board, 0, j);
            DFS(board, rows - 1, j);
        }

        // Step 2: Flip and restore
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O')
                    board[i][j] = 'X';     // captured
                else if (board[i][j] == '#')
                    board[i][j] = 'O';     // restore safe
            }
        }
    }

    private void DFS(char[][] board, int i, int j)
    {
        if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length ||
            board[i][j] != 'O')
            return;

        // Mark safe
        board[i][j] = '#';

        DFS(board, i + 1, j);
        DFS(board, i - 1, j);
        DFS(board, i, j + 1);
        DFS(board, i, j - 1);
    }
}