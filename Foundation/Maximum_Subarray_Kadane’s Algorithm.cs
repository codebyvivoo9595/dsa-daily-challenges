using System;

class MaximumSubarray
{
    static void Main()
    {
        int[] nums = {-2,1,-3,4,-1,2,1,-5,4};

        int currentSum = nums[0]; // Start with first element
        int maxSum = nums[0];     // Track maximum sum

        for (int i = 1; i < nums.Length; i++)
        {
            // Either extend the current sum or start fresh from nums[i]
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            // Update maxSum if currentSum is greater
            maxSum = Math.Max(maxSum, currentSum);

            // Debug notes
            Console.WriteLine($"Step {i}: nums[i]={nums[i]}, currentSum={currentSum}, maxSum={maxSum}");
        }

        Console.WriteLine($"Maximum Subarray Sum = {maxSum}");
    }
}
