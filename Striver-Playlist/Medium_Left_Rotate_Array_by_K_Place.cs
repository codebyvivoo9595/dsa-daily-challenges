public class Solution {
    public int[] HelperLeftOneRotationOfArray(int[] nums)
        {
           int firstPlace = nums[0]; 
           int n = nums.Length; 
           for(int i = 1; i < n ; i++)
           {
              //That value should be place in i-1 position.
              nums[i-1] = nums[i];
              //This will Traverse the array and set the value in i-1 location
           }

           //Lastly last value we need to add that value is in n-1 location so
           nums[n-1] = firstPlace;
           return nums;
        } 

    public void Rotate(int[] nums, int k) {
        // See what i can do i know the one left rotation 
        // let suppose they are asking rotate array 3 time 
        //so i will that function 3 time 
        //So array will rotate 3 times

    
        //Now comes the main part 
        //How many time i need to rotate array is k

        for (int i = 0 ; i < k; i++)
        {
           nums = HelperLeftOneRotationOfArray(nums);
        }

    }
}