public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        // idea: use a dictionary to count frequency of elements in nums1
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // build frequency map for nums1
        foreach(int num in nums1) {
            if(freq.ContainsKey(num)) {
                freq[num]++; // increment count
            } else {
                freq[num] = 1; // first time seeing this number
            }
        }

        List<int> result = new List<int>();

        // now check nums2 against the map
        foreach(int num in nums2) {
            if(freq.ContainsKey(num) && freq[num] > 0) {
                result.Add(num);   // add to intersection
                freq[num]--;       // reduce count (so duplicates handled correctly)
                // debug note: when freq goes to 0, that number is "used up"
            }
        }

        return result.ToArray(); // convert list to array
    }
}
