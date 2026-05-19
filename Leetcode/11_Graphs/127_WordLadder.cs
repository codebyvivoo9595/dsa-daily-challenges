/*
========================================================
LeetCode Problem: 127. Word Ladder
Pattern: Advanced Graphs (BFS)
Difficulty: Hard (VERY IMPORTANT)

LeetCode Link:
https://leetcode.com/problems/word-ladder/

--------------------------------------------------------
Problem Statement

Given:
- beginWord
- endWord
- wordList

Return length of shortest transformation sequence.

Rules:
1. Change only one character at a time
2. Each transformed word must exist in wordList

Example:

Input:
beginWord = "hit"
endWord = "cog"
wordList = ["hot","dot","dog","lot","log","cog"]

Output:
5

Explanation:
hit -> hot -> dot -> dog -> cog

--------------------------------------------------------
Approach : BFS (Shortest Path)

Idea:
1. Store words in HashSet
2. Start BFS from beginWord
3. Change one character at a time
4. Valid word → enqueue
5. First time reaching endWord = shortest path

Time Complexity:
O(N * L * 26)

N = number of words
L = word length

Space Complexity:
O(N)

========================================================
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> words = new HashSet<string>(wordList);

        if (!words.Contains(endWord))
            return 0;

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);

        HashSet<string> visited = new HashSet<string>();
        visited.Add(beginWord);

        int level = 1;

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                string word = queue.Dequeue();

                if (word == endWord)
                    return level;

                char[] arr = word.ToCharArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    char original = arr[j];

                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        arr[j] = c;

                        string nextWord = new string(arr);

                        if (words.Contains(nextWord) &&
                            !visited.Contains(nextWord))
                        {
                            visited.Add(nextWord);
                            queue.Enqueue(nextWord);
                        }
                    }

                    arr[j] = original;
                }
            }

            level++;
        }

        return 0;
    }
}