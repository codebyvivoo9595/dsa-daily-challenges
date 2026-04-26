/*
========================================================
LeetCode Problem: 79. Word Search
Pattern: Backtracking (Grid Traversal)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/word-search/

--------------------------------------------------------
Problem Statement

Given an m x n grid of characters board and a string word,
return true if the word exists in the grid.

Rules:
- Letters must be adjacent (up, down, left, right)
- Same cell cannot be used more than once

Example:

Input:
board =
[
 ['A','B','C','E'],
 ['S','F','C','S'],
 ['A','D','E','E']
]
word = "ABCCED"

Output:
true

--------------------------------------------------------
Approach : Backtracking (DFS on Grid)

Idea:
Start from every cell and try to match the word.

Steps:
1. Iterate all cells
2. Start DFS if first character matches
3. Explore 4 directions
4. Mark visited temporarily
5. Backtrack

Time Complexity:
O(m * n * 4^L)

Space Complexity:
O(L)

========================================================
*/

using System;

public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (DFS(board, word, i, j, 0))
                    return true;
            }
        }

        return false;
    }

    private bool DFS(char[][] board, string word, int i, int j, int index)
    {
        // If all characters matched
        if (index == word.Length)
            return true;

        // Boundary + mismatch check
        if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length ||
            board[i][j] != word[index])
            return false;

        // Mark visited
        char temp = board[i][j];
        board[i][j] = '#';

        // Explore 4 directions
        bool found =
            DFS(board, word, i + 1, j, index + 1) ||
            DFS(board, word, i - 1, j, index + 1) ||
            DFS(board, word, i, j + 1, index + 1) ||
            DFS(board, word, i, j - 1, index + 1);

        // Backtrack (restore)
        board[i][j] = temp;

        return found;
    }
}