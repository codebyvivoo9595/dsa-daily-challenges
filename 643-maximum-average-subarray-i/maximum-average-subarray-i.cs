public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // idea: use sliding window of size k
        // first compute sum of first k elements
        int windowSum = 0;
        for (int i = 0; i < k; i++) {
            windowSum += nums[i];
        }

        // keep track of max sum seen so far
        int maxSum = windowSum;

        // now slide the window across the array
        for (int i = k; i < nums.Length; i++) {
            // remove the element going out of window (nums[i-k])
            // add the new element coming in (nums[i])
            windowSum = windowSum - nums[i - k] + nums[i];

            // debug note: at each step, window covers nums[i-k+1..i]
            // example: when i=3 and k=2, window is nums[2..3]

            // update max if current window sum is bigger
            if (windowSum > maxSum) {
                maxSum = windowSum;
            }
        }

        // return max average (sum / k)
        return (double)maxSum / k;
    }
}
