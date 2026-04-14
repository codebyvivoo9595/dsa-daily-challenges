/*
========================================================
LeetCode Problem: 21. Merge Two Sorted Lists
Pattern: Linked List
Difficulty: Easy (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/merge-two-sorted-lists/

--------------------------------------------------------
Problem Statement

You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list and return it.

Example:

Input:
list1 = 1 -> 2 -> 4
list2 = 1 -> 3 -> 4

Output:
1 -> 1 -> 2 -> 3 -> 4 -> 4

--------------------------------------------------------
Approach #1 : Iterative (Optimal)

Idea:
Use a dummy node and compare nodes one by one.

Steps:
1. Create dummy node
2. Use pointer current
3. Compare list1 and list2
4. Attach smaller node
5. Move pointer
6. Attach remaining nodes

Time Complexity:
O(n + m)

Space Complexity:
O(1)

--------------------------------------------------------
Approach #2 : Recursive

Idea:
Choose smaller node and recursively merge rest.

Time Complexity:
O(n + m)

Space Complexity:
O(n + m)

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

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        // Attach remaining
        if (list1 != null)
        {
            current.next = list1;
        }
        else
        {
            current.next = list2;
        }

        return dummy.next;
    }

    /*
    ========================================================
    Approach #2 : Recursive
    ========================================================

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }

    */
}