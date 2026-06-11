public class Solution {
    public int[] SortedSquares(int[] nums) {
        int [] result = new int [nums.Length];

        int i = 0,
            j = nums.Length-1;

        int k = nums.Length-1; 


        while(i<=j)
        {
            if(Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                result[k] = nums[i] * nums[i]; 
                i++;
            }else
            {
                result[k] = nums[j] * nums[j];
                j--;
            }

            k--;
        }   

        return result;
    }
}public class Solution {
    public int[] SortedSquares(int[] nums) {
        int [] result = new int [nums.Length];

        int i = 0,
            j = nums.Length-1;

        int k = nums.Length-1; 


        while(i<=j)
        {
            if(Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                result[k] = nums[i] * nums[i]; 
                i++;
            }else
            {
                result[k] = nums[j] * nums[j];
                j--;
            }

            k--;
        }   

        return result;
    }
}