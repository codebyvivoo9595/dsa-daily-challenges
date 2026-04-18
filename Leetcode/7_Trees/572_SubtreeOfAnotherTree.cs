/*
========================================================
LeetCode Problem: 572. Subtree of Another Tree
Pattern: Trees (DFS + Comparison)
Difficulty: Easy-Medium

LeetCode Link:
https://leetcode.com/problems/subtree-of-another-tree/

--------------------------------------------------------
Problem Statement

Given the roots of two binary trees root and subRoot,
return true if subRoot is a subtree of root.

A subtree is a node in root and all of its descendants
must match subRoot.

--------------------------------------------------------
Approach : DFS + Same Tree Check

Idea:
Traverse main tree and check at each node:
"Is this subtree same as subRoot?"

Steps:
1. If root is null → return false
2. If trees match → return true
3. Recursively check left or right

Time Complexity:
O(n * m)

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
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
            return false;

        if (IsSameTree(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) ||
               IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;

        if (p == null || q == null)
            return false;

        if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) &&
               IsSameTree(p.right, q.right);
    }
}