public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0) return 0;

        int i = 0; // pointer for unique position

        for(int j = 1; j < nums.Length; j++) {
            if(nums[j] != nums[i]) {
                i++;
                nums[i] = nums[j]; // place unique element
            }
        }

        return i + 1; // new length of unique array
    }
}
