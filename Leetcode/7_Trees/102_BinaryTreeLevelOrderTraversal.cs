/*
========================================================
LeetCode Problem: 102. Binary Tree Level Order Traversal
Pattern: Trees (BFS / Queue)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/binary-tree-level-order-traversal/

--------------------------------------------------------
Problem Statement

Given the root of a binary tree, return the level order
traversal of its nodes' values.

(Level by level, left to right)

Example:

Input:
    3
   / \
  9  20
     / \
    15  7

Output:
[
 [3],
 [9,20],
 [15,7]
]

--------------------------------------------------------
Approach : BFS (Queue)

Idea:
Traverse tree level by level using queue.

Steps:
1. Add root to queue
2. While queue not empty:
   - Get current level size
   - Process all nodes of that level
   - Add children to queue

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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null)
            return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int size = queue.Count;
            List<int> level = new List<int>();

            for (int i = 0; i < size; i++)
            {
                TreeNode node = queue.Dequeue();
                level.Add(node.val);

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            result.Add(level);
        }

        return result;
    }
}