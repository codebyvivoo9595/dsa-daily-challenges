using System;

class ProductExceptSelf
{
    static void Main()
    {
        int[] nums = {1,2,3,4};
        int n = nums.Length;

        int[] result = new int[n];
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        // Step 1: Build prefix products
        prefix[0] = 1; // nothing before first element
        for (int i = 1; i < n; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
            Console.WriteLine($"Prefix[{i}] = {prefix[i]}");
        }

        // Step 2: Build suffix products
        suffix[n-1] = 1; // nothing after last element
        for (int i = n-2; i >= 0; i--)
        {
            suffix[i] = suffix[i+1] * nums[i+1];
            Console.WriteLine($"Suffix[{i}] = {suffix[i]}");
        }

        // Step 3: Result = prefix[i] * suffix[i]
        for (int i = 0; i < n; i++)
        {
            result[i] = prefix[i] * suffix[i];
            Console.WriteLine($"Result[{i}] = {result[i]}");
        }

        Console.WriteLine("Final Answer: " + string.Join(",", result));
    }
}
