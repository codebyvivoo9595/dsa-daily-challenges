using System;
using System.Collections.Generic;

class MergeIntervals
{
    static void Main()
    {
        int[][] intervals = new int[][]
        {
            new int[] {1,3},
            new int[] {2,6},
            new int[] {8,10},
            new int[] {15,18}
        };

        // Step 1: Sort intervals by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int[] current = intervals[0];

        foreach (var interval in intervals)
        {
            // Debug notes
            Console.WriteLine($"Checking interval: [{interval[0]}, {interval[1]}]");

            if (interval[0] <= current[1])
            {
                // Overlap → merge
                current[1] = Math.Max(current[1], interval[1]);
                Console.WriteLine($"Merged to: [{current[0]}, {current[1]}]");
            }
            else
            {
                // No overlap → add current and move forward
                merged.Add(current);
                current = interval;
            }
        }

        // Add the last interval
        merged.Add(current);

        // Print result
        foreach (var arr in merged)
        {
            Console.WriteLine($"[{arr[0]}, {arr[1]}]");
        }
    }
}
