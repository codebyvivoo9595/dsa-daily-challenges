/*
========================================================
LeetCode Problem: 155. Min Stack
Pattern: Stack (Design)
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/min-stack/

--------------------------------------------------------
Problem Statement

Design a stack that supports the following operations:

1. push(x) → Push element x onto stack
2. pop() → Removes element on top
3. top() → Get top element
4. getMin() → Retrieve minimum element in the stack

All operations must be in O(1) time.

--------------------------------------------------------
Approach #1 : Brute Force

Idea:
Store elements in stack and find min by traversing.

getMin() → O(n)

Not optimal.

--------------------------------------------------------
Approach #2 : Two Stacks (Optimal)

Idea:
Use:
1. Main stack → store elements
2. Min stack → store minimum values

Steps:
- Push:
    Push element to main stack
    Push to min stack if it's smaller or equal

- Pop:
    If popped element == min stack top → pop from min stack

- getMin:
    Return top of min stack

Time Complexity:
All operations → O(1)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);

        // Push to minStack if it's smaller or equal
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }

    public void Pop()
    {
        if (stack.Pop() == minStack.Peek())
        {
            minStack.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}