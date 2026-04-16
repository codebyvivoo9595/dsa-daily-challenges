/*
========================================================
LeetCode Problem: 543. Diameter of Binary Tree
Pattern: Trees (DFS + Height Calculation)
Difficulty: Easy-Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/diameter-of-binary-tree/

--------------------------------------------------------
Problem Statement

Given the root of a binary tree, return the length of
the diameter.

Diameter = length of longest path between any two nodes.

The path may or may not pass through the root.

Example:

Input:
    1
   / \
  2   3
 / \
4   5

Output:
3  (path: 4 → 2 → 1 → 3)

--------------------------------------------------------
Approach : DFS + Height

Idea:
At each node:
Diameter = left height + right height

Steps:
1. Calculate height of left subtree
2. Calculate height of right subtree
3. Update global diameter
4. Return height to parent

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
    int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        Depth(root);
        return diameter;
    }

    private int Depth(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = Depth(node.left);
        int right = Depth(node.right);

        // Update diameter
        diameter = Math.Max(diameter, left + right);

        // Return height
        return 1 + Math.Max(left, right);
    }
}