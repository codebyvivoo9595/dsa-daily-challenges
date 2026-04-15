/*
========================================================
LeetCode Problem: 104. Maximum Depth of Binary Tree
Pattern: Trees (DFS)
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/maximum-depth-of-binary-tree/

--------------------------------------------------------
Problem Statement

Given the root of a binary tree, return its maximum depth.

Maximum depth = number of nodes along longest path
from root to leaf.

Example:

Input:
    3
   / \
  9  20
     / \
    15  7

Output:
3

--------------------------------------------------------
Approach #1 : Recursion (DFS)

Idea:
Depth = 1 + max(left depth, right depth)

Time Complexity:
O(n)

Space Complexity:
O(h) (height of tree)

--------------------------------------------------------
Approach #2 : Iterative (BFS)

Idea:
Level order traversal using queue

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
    Approach #1 : DFS (Recursive)
    ========================================================
    */

    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }

    /*
    ========================================================
    Approach #2 : BFS (Iterative)
    ========================================================

    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int depth = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            depth++;
        }

        return depth;
    }

    */
}