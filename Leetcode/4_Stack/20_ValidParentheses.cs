/*
========================================================
LeetCode Problem: 20. Valid Parentheses
Pattern: Stack
Difficulty: Easy

LeetCode Link:
https://leetcode.com/problems/valid-parentheses/

--------------------------------------------------------
Problem Statement

Given a string s containing just the characters:
'(', ')', '{', '}', '[' and ']',

Determine if the input string is valid.

A string is valid if:
1. Open brackets must be closed by same type
2. Open brackets must be closed in correct order

Example:

Input:
s = "()[]{}"

Output:
true

Input:
s = "(]"

Output:
false

--------------------------------------------------------
Approach : Stack

Idea:
Use stack to track opening brackets.

Steps:
1. Traverse string
2. If opening → push to stack
3. If closing → check top of stack
4. If mismatch → return false
5. At end → stack should be empty

Time Complexity:
O(n)

Space Complexity:
O(n)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            // Push opening brackets
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                // If stack empty or mismatch
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}