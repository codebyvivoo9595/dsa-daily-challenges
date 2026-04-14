/*
========================================================
LeetCode Problem: 141. Linked List Cycle
Pattern: Linked List (Fast & Slow Pointers)
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/linked-list-cycle/

--------------------------------------------------------
Problem Statement

Given head of a linked list, determine if the linked list
has a cycle in it.

A cycle exists if some node points back to a previous node.

--------------------------------------------------------
Approach #1 : HashSet

Idea:
Store visited nodes.
If node repeats → cycle exists.

Time Complexity:
O(n)

Space Complexity:
O(n)

--------------------------------------------------------
Approach #2 : Fast & Slow Pointer (Optimal)

Idea:
Use two pointers:
- slow → moves 1 step
- fast → moves 2 steps

If cycle exists → they will meet.

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    /*
    ========================================================
    Approach #1 : HashSet
    ========================================================

    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();

        while (head != null)
        {
            if (set.Contains(head))
                return true;

            set.Add(head);
            head = head.next;
        }

        return false;
    }

    */

    // =====================================================
    // Approach #2 : Fast & Slow Pointer (Optimal)
    // =====================================================

    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;           // move 1 step
            fast = fast.next.next;      // move 2 steps

            if (slow == fast)
                return true;            // cycle detected
        }

        return false;
    }
}