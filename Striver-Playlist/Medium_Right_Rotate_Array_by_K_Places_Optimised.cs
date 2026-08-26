 public class Right_Rotate_Array_by_K_Places_Optimised
 {
     public int[] ReverseHelper(int[] nums, int i, int j)
     {
         //int i = 0;
         //int j = nums.Length - 1;
         //Here we are using now start and end as the pointer for array reversal instead of i and j.
         //So using this we can pass the subarray of the array and reverse that subarray.
         while (i < j) 
         {
             // i will 2 pointers for Arry reversal and j will be the other pointer for array reversal.
             // This condition will work for both conditions i.e. if the array is even or odd length.
             int temp = nums[i];
             nums[i] = nums[j]; 
             nums[j] = temp;

             i++;
             j--;
         }
         return nums;
     }
     public static void Main(String[] args)
     {
         int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
         Right_Rotate_Array_by_K_Places_Optimised obj = new Right_Rotate_Array_by_K_Places_Optimised();

         // Now here is the catch we need to do k%nums.Length because if the value of k is greater than nums.Length
         // then we will do the same rotation again and again.

         int k = 10 % nums.Length;
         //This done because the let suppose 15 time rotate 15 means (7+7+1) 7 7 will be same as the original array so we need to do only 1 rotation. 

         // Basically what we are doing here see 
         //[1,2,3,4,5,6,7]  and if k = 3 then we need to rotate the array by 3 places so the output will be [5,6,7,1,2,3,4]
         //Step 1: [-,-,-,-,5,6,7] rotate n-k to n-1 range becuase they have ask from right (if they ask from left will do same by left)
         //After Rotating  [7,6,5]
         //Step 2:         [1,2,3,4,-,-,-] rotate 0 to n-k-1 becuase they have ask from right (if they ask from left will do same by left)
         //After Rotating  [4,3,2,1]
         //Step 3:         Add both arrays
         //After Rotating  [4,3,2,1,7,6,5]
         //Final Step:     Reverse the whole array to get the final output.
         //So the final output will be [5,6,7,1,2,3,4]

         //Step 1:
         nums = obj.ReverseHelper(nums, nums.Length - k, nums.Length - 1);
         //Step 2:
         nums = obj.ReverseHelper(nums, 0, nums.Length - k - 1);
         //Final Step:
         nums = obj.ReverseHelper(nums, 0, nums.Length - 1);


         foreach (var i in nums)
         {
          Console.Write(i + " ");
         }




     }
 }