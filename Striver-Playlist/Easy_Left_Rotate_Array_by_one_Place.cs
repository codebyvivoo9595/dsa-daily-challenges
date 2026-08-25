public class Solution
{
    public void rotateArray(List<int> nums)
    {
        //We are given an array that we have to rotate by one Place 
       //[1,2,3,4,5] after left rotate [2,3,4,5,1]
      //This Should be the output
       int FirstPlace = nums[0]; 
       int n = nums.Count;
       for(int i = 1; i< n ; i++)
       {
          nums[i-1] = nums[i];
       }

       nums[n-1] = FirstPlace;
    }  
}