/*
========================================================
LeetCode Problem: 150. Evaluate Reverse Polish Notation
Pattern: Stack
Difficulty: Medium

LeetCode Link:
https://leetcode.com/problems/evaluate-reverse-polish-notation/

--------------------------------------------------------
Problem Statement

Evaluate the value of an arithmetic expression in
Reverse Polish Notation.

Valid operators are: +, -, *, /

Each operand may be an integer or another expression.

Example:

Input:
tokens = ["2","1","+","3","*"]

Output:
9

Explanation:
((2 + 1) * 3) = 9

--------------------------------------------------------
Approach : Stack

Idea:
1. Traverse tokens
2. If number → push to stack
3. If operator → pop two elements
4. Apply operation
5. Push result back

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
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                int b = stack.Pop(); // second operand
                int a = stack.Pop(); // first operand

                int result = 0;

                switch (token)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                }

                stack.Push(result);
            }
            else
            {
                // number
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}