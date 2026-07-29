public class Solution {
    public int[] SortedSquares(int[] nums) {
        // Create a result array of the same length as nums
        int [] result = new int [nums.Length];
 
        // i points to the start (left side)
        int i = 0,
            // j points to the end (right side)
            j = nums.Length-1;
 
        // k points to the last index of result (we fill from the back)
        int k = nums.Length-1;
 
        // Loop until both pointers meet
        while(i<=j)
        {    
            // Why compare absolute values?
            // Because the array is sorted, but negative numbers can have larger squares.
            // Example: -7 squared (49) is bigger than 3 squared (9).
            // So we must check which side has the bigger absolute value.
           
            if(Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                // If left side has bigger absolute value, square it
                result[k] = nums[i] * nums[i];
                // Move left pointer forward
                i++;
            }else
            {
                // Otherwise, square the right side
                result[k] = nums[j] * nums[j];
                // Move right pointer backward
                j--;
            }
 
            // Move k backward (fill result from end to start)
            k--;
        }  
 
        // Return the sorted squares
        return result;
    }
}
