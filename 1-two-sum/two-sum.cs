using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // dictionary to store number -> index
        Dictionary<int, int> map = new Dictionary<int, int>();

        // loop through all numbers
        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i]; // what number we need to reach target

            // check if we already saw the needed number
            if (map.ContainsKey(needed))
            {
                // found the pair → return indices
                return new int[] { map[needed], i };
            }

            // store current number with its index
            map[nums[i]] = i;

            // debug note: map keeps track of seen numbers
            // example: nums = [2,7,11,15], target=9
            // i=0 → nums[0]=2, needed=7 → not found → store {2:0}
            // i=1 → nums[1]=7, needed=2 → found in map → return {0,1}
        }

        // if no pair found
        return new int[] { };
    }
}
