public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; // normalize k

        Reverse(nums, 0, n - 1);      // Step 1: reverse whole array
        Reverse(nums, 0, k - 1);      // Step 2: reverse first k elements
        Reverse(nums, k, n - 1);      // Step 3: reverse remaining elements
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
