/*
========================================================
LeetCode Problem: 206. Reverse Linked List
Pattern: Linked List
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/reverse-linked-list/

--------------------------------------------------------
Problem Statement

Given the head of a singly linked list, reverse the list,
and return the reversed list.

Example:

Input:
1 -> 2 -> 3 -> 4 -> 5

Output:
5 -> 4 -> 3 -> 2 -> 1

--------------------------------------------------------
Approach #1 : Iterative (Optimal)

Idea:
Reverse pointers one by one.

Steps:
1. prev = null
2. current = head
3. Save next node
4. Reverse link
5. Move forward

Time Complexity:
O(n)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Recursive

Idea:
Reverse rest of list and fix current node.

Time Complexity:
O(n)

Space Complexity:
O(n) (stack)

========================================================
*/

using System;

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
    Approach #1 : Iterative (Optimal)
    ========================================================
    */

    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode next = current.next; // store next
            current.next = prev;          // reverse link
            prev = current;               // move prev
            current = next;               // move current
        }

        return prev;
    }

    /*
    ========================================================
    Approach #2 : Recursive
    ========================================================

    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode newHead = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return newHead;
    }

    */
}