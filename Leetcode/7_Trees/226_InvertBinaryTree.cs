/*
========================================================
LeetCode Problem: 226. Invert Binary Tree
Pattern: Trees (DFS)
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/invert-binary-tree/

--------------------------------------------------------
Problem Statement

Given the root of a binary tree, invert the tree,
and return its root.

Invert = swap left and right children at every node.

Example:

Input:
    4
   / \
  2   7
 / \ / \
1  3 6  9

Output:
    4
   / \
  7   2
 / \ / \
9  6 3  1

--------------------------------------------------------
Approach #1 : Recursion (DFS)

Idea:
Swap left and right for every node.

Steps:
1. Base case: null → return
2. Swap left and right
3. Recurse on children

Time Complexity:
O(n)

Space Complexity:
O(h)

--------------------------------------------------------
Approach #2 : Iterative (BFS)

Idea:
Use queue and swap nodes level by level.

Time Complexity:
O(n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

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
    Approach #1 : Recursive (DFS)
    ========================================================
    */

    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        // Swap
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        // Recurse
        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }

    /*
    ========================================================
    Approach #2 : Iterative (BFS)
    ========================================================

    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();

            // Swap
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            if (node.left != null)
                queue.Enqueue(node.left);

            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return root;
    }

    */
}