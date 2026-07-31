public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        // Convert IList<int> to List<int> so we can sort easily
        List<int> list = nums.ToList();
        list.Sort(); // Sort ascending

        int i = 0;                     // left pointer
        int j = list.Count - 1;        // right pointer (Count instead of Size())
        int count = 0;                 // total pairs

        // Loop until pointers meet
        while (i < j)
        {
            int sum = list[i] + list[j]; // use list[i], list[j] (not get())

            if (sum < target)
            {
                // If sum < target, then all pairs between i and j are valid
                // Because list is sorted, every element from i+1 to j with list[i] will also be < target
                count += (j - i);

                // Debug note: move left pointer forward to check next possible pair
                i++;
            }
            else
            {
                // If sum >= target, we need smaller values → move right pointer backward
                j--;
            }
        }

        return count;
    }
}
