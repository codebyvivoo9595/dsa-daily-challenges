using System;
using System.Collections.Generic;

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> result = new List<string>();
        if (nums.Length == 0) return result;

        int start = nums[0]; // beginning of current range

        for (int i = 1; i <= nums.Length; i++) {
            // Check if end of array OR break in consecutive sequence
            if (i == nums.Length || nums[i] != nums[i - 1] + 1) {
                if (start == nums[i - 1]) {
                    // Single number
                    result.Add(start.ToString());
                } else {
                    // Range
                    result.Add(start + "->" + nums[i - 1]);
                }

                // Reset start if not at end
                if (i < nums.Length) {
                    start = nums[i];
                }
            }
        }

        return result;
    }
}
