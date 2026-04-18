/*
========================================================
LeetCode Problem: 235. Lowest Common Ancestor of a BST
Pattern: Trees (BST Property)
Difficulty: Easy-Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/

--------------------------------------------------------
Problem Statement

Given a Binary Search Tree (BST), find the lowest common
ancestor (LCA) of two given nodes p and q.

LCA = lowest node that has both p and q as descendants.

Example:

Input:
        6
       / \
      2   8
     / \ / \
    0  4 7  9
      / \
     3   5

p = 2, q = 8

Output:
6

--------------------------------------------------------
Approach : Using BST Property

Idea:
In BST:
left < root < right

Steps:
1. If both p & q < root → go left
2. If both p & q > root → go right
3. Else → current node is LCA

Time Complexity:
O(h)

Space Complexity:
O(1)

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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        while (root != null)
        {
            if (p.val < root.val && q.val < root.val)
            {
                root = root.left;
            }
            else if (p.val > root.val && q.val > root.val)
            {
                root = root.right;
            }
            else
            {
                return root;
            }
        }

        return null;
    }
}