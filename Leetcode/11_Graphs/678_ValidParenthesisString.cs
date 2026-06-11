/*
========================================================
LeetCode Problem: 678. Valid Parenthesis String
Pattern: Greedy (Range Greedy)
Difficulty: Medium (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/valid-parenthesis-string/

--------------------------------------------------------
Problem Statement

Given string s containing:
'(' ')' '*'

'*' can represent:
1. '('
2. ')'
3. empty string

Return true if string can be valid.

--------------------------------------------------------
Approach : Greedy (Lower/Upper Bound)

Idea:
Track possible range of open brackets.

leftMin = minimum open brackets
leftMax = maximum open brackets

Rules:
'(' -> ++ both
')' -> -- both
'*' -> leftMin-- , leftMax++

If leftMax < 0 → invalid

Time Complexity:
O(n)

Space Complexity:
O(1)

========================================================
*/

using System;

public class Solution
{
    public bool CheckValidString(string s)
    {
        int leftMin = 0;
        int leftMax = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                leftMin++;
                leftMax++;
            }
            else if (c == ')')
            {
                leftMin--;
                leftMax--;
            }
            else // '*'
            {
                leftMin--;
                leftMax++;
            }

            // Too many closing
            if (leftMax < 0)
                return false;

            // Minimum cannot be negative
            if (leftMin < 0)
                leftMin = 0;
        }

        return leftMin == 0;
    }
}