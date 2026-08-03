using System;

class RotateArray
{
    static void Main()
    {
        int[] nums = {1,2,3,4,5,6,7};
        int k = 3;

        // Step 1: Normalize k (in case k > length)
        k = k % nums.Length; // Debug: nums.Length = 7, k = 3

        // Step 2: Reverse whole array
        Reverse(nums, 0, nums.Length - 1); 
        // Debug: nums = {7,6,5,4,3,2,1}

        // Step 3: Reverse first k elements
        Reverse(nums, 0, k - 1); 
        // Debug: nums = {5,6,7,4,3,2,1}

        // Step 4: Reverse remaining elements
        Reverse(nums, k, nums.Length - 1); 
        // Debug: nums = {5,6,7,1,2,3,4}

        Console.WriteLine(string.Join(",", nums));
    }

    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            // Debug: swapping arr[start] and arr[end]
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }
}
