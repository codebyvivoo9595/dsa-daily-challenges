using System;
using System.Collections.Generic;

class LongestSubstring
{
    static void Main()
    {
        string s = "abcabcbb";

        // Dictionary to store last seen index of each character
        Dictionary<char, int> seen = new Dictionary<char, int>();

        int left = 0;   // Left pointer of sliding window
        int maxLen = 0; // Result variable

        // Traverse with right pointer
        for (int right = 0; right < s.Length; right++)
        {
            char current = s[right];

            // If character already seen and within current window
            if (seen.ContainsKey(current) && seen[current] >= left)
            {
                // Move left pointer to one position after last seen
                left = seen[current] + 1;
            }

            // Update last seen index of current character
            seen[current] = right;

            // Calculate window length
            int windowLen = right - left + 1;

            // Update max length if needed
            if (windowLen > maxLen)
                maxLen = windowLen;

            // Debug notes
            Console.WriteLine($"Step {right}: char={current}, left={left}, right={right}, windowLen={windowLen}, maxLen={maxLen}");
        }

        Console.WriteLine($"Longest substring length = {maxLen}");
    }
}
