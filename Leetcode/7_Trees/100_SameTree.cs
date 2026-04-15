/*
========================================================
LeetCode Problem: 100. Same Tree
Pattern: Trees (DFS)
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/same-tree/

--------------------------------------------------------
Problem Statement

Given the roots of two binary trees p and q,
return true if they are the same.

Two trees are the same if:
1. They are structurally identical
2. Nodes have the same values

Example:

Input:
p = [1,2,3]
q = [1,2,3]

Output:
true

--------------------------------------------------------
Approach : Recursion (DFS)

Idea:
Compare both trees node by node.

Steps:
1. If both null → true
2. If one null → false
3. If values differ → false
4. Recursively check left & right

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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        // Case 1: both null
        if (p == null && q == null)
            return true;

        // Case 2: one null
        if (p == null || q == null)
            return false;

        // Case 3: value mismatch
        if (p.val != q.val)
            return false;

        // Case 4: check subtrees
        return IsSameTree(p.left, q.left) &&
               IsSameTree(p.right, q.right);
    }
}