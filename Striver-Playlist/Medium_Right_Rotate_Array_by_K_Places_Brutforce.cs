public class Right_Rotate_Array_by_K_Places_Brutforce
{

    //This Solution is not optimal because we are doing one rotation
    //at a time and if we have to do k rotations then we will do this k times.
    //So the time complexity will be O(n*k) and space complexity will be O(1).
    //So it Will get the Time Out Exceotion in leet code for large input values of k and n.

    //Right_Rotate_Array_by_K_Places_Optimised version also there check that one 
    public int[] HelperRightOneRotationOfArray(int[] nums)
    {
        int n = nums.Length;
        int LastPlace = nums[n-1];
        
        for (int i = 0; i < n; i++)
        {
            //That value should be place in i-1 position.
            nums[i + 1] = nums[i];
            //This will Traverse the array and set the value in i-1 location
        }

        //Lastly last value we need to add that value is in n-1 location so
        nums[0] = LastPlace;
        return nums;
    }


    public static void Main(string[] args)
    {
        Right_Rotate_Array_by_K_Places_Brutforce obj = new Right_Rotate_Array_by_K_Places_Brutforce();

        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

        int k = 3;
        nums = obj.HelperRightOneRotationOfArray(nums);


        for (int i = 0; i < k; i++)
        {
            nums = obj.HelperRightOneRotationOfArray(nums);
        }

        foreach (var item in nums)
        {
            Console.WriteLine(item + " ");
        }

    }
}