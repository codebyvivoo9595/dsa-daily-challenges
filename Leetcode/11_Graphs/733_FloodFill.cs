/*
========================================================
LeetCode Problem: 733. Flood Fill
Pattern: Graphs (DFS / BFS)
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/flood-fill/

--------------------------------------------------------
Problem Statement

Given an image represented by a 2D array, a starting pixel
(sr, sc), and a new color, fill all connected pixels
with the same original color.

--------------------------------------------------------
Approach : DFS

Idea:
1. Get original color
2. DFS from starting cell
3. Replace all connected cells with new color

Time Complexity:
O(m * n)

Space Complexity:
O(m * n)

========================================================
*/

using System;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int originalColor = image[sr][sc];

        // If same color, no need to process
        if (originalColor == color)
            return image;

        DFS(image, sr, sc, originalColor, color);

        return image;
    }

    private void DFS(int[][] image, int i, int j, int originalColor, int newColor)
    {
        if (i < 0 || j < 0 || i >= image.Length || j >= image[0].Length ||
            image[i][j] != originalColor)
            return;

        // Color change
        image[i][j] = newColor;

        DFS(image, i + 1, j, originalColor, newColor);
        DFS(image, i - 1, j, originalColor, newColor);
        DFS(image, i, j + 1, originalColor, newColor);
        DFS(image, i, j - 1, originalColor, newColor);
    }
}