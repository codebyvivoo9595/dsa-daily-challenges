/*
========================================================
LeetCode Problem: 110. Balanced Binary Tree
Pattern: Trees (DFS + Height Check)
Difficulty: Easy-Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/balanced-binary-tree/

--------------------------------------------------------
Problem Statement

Given a binary tree, determine if it is height-balanced.

A binary tree is balanced if:

|height(left) - height(right)| <= 1 for every node

Example:

Input:
    3
   / \
  9  20
     / \
    15  7

Output:
true

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
For every node, calculate height separately

Time Complexity:
O(n^2)

--------------------------------------------------------
Approach #2 : DFS (Optimal)

Idea:
Check balance while calculating height.

Steps:
1. Compute left height
2. Compute right height
3. If difference > 1 → return -1 (unbalanced)
4. Else return height

Time Complexity:
O(n)

Space Complexity:
O(h)

========================================================
*/

using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    /*
    ========================================================
    Approach #2 : DFS (Optimal)
    ========================================================
    */

    public bool IsBalanced(TreeNode root)
    {
        return Height(root) != -1;
    }

    private int Height(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = Height(node.left);
        if (left == -1) return -1;

        int right = Height(node.right);
        if (right == -1) return -1;

        if (Math.Abs(left - right) > 1)
            return -1;

        return 1 + Math.Max(left, right);
    }
}