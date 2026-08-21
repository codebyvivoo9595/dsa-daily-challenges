/*
Second Largest Element
Subscribe to TUF+

Hints
Company
Given an array of integers nums, return the second-largest element in the array. If the second-largest element does not exist, return -1.


Example 1

Input: nums = [8, 8, 7, 6, 5]

Output: 7

Explanation:

The largest value in nums is 8, the second largest is 7

Example 2

Input: nums = [10, 10, 10, 10, 10]

Output: -1

Explanation:

The only value in nums is 10, so there is no second largest value, thus -1 is returned


*/



public class Solution
{

    public int SecondLargestElemenet(List<int> nums)
    {
        int Large_val = int.MinValue;
        int SLarge_val = int.MinValue;

        for(int i = 0 ; i < nums.Count; i++ )
        {
            if(nums[i] > Large_val)
            {   
                SLarge_val = Large_val;
                Large_val = nums[i];
            }
            else if(nums[i] < Large_val && nums[i] > SLarge_val )
            {
                SLarge_val = nums[i];
            }
        }

        return (SLarge_val == int.MinValue) ? -1 :  SLarge_val;
    }
}