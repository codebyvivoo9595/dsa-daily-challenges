public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Ensure nums1 is the smaller array
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;

        while (left <= right) {
            int partition1 = (left + right) / 2;
            int partition2 = (m + n + 1) / 2 - partition1;

            // Handle edges with +/- infinity
            int maxLeft1 = (partition1 == 0) ? int.MinValue : nums1[partition1 - 1];
            int minRight1 = (partition1 == m) ? int.MaxValue : nums1[partition1];
            int maxLeft2 = (partition2 == 0) ? int.MinValue : nums2[partition2 - 1];
            int minRight2 = (partition2 == n) ? int.MaxValue : nums2[partition2];

            // Correct partition found
            if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1) {
                if ((m + n) % 2 == 0) {
                    return (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0;
                } else {
                    return Math.Max(maxLeft1, maxLeft2);
                }
            }
            else if (maxLeft1 > minRight2) {
                // Move partition left
                right = partition1 - 1;
            } else {
                // Move partition right
                left = partition1 + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted");
    }
}
