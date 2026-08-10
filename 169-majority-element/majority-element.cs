using System;
using System.Collections.Generic;

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> frq = new Dictionary<int,int>();
        int Dividefactor = nums.Length / 2;  

        // Approach 1: Dictionary Frequency Count
        foreach(int n in nums) {
            if(frq.ContainsKey(n)) {
                frq[n]++;
            } else {
                frq[n] = 1;
            }
        }   

        // Find majority element
        foreach(var Keyvaluevpair in frq) {
            if(Keyvaluevpair.Value > Dividefactor) {
                return Keyvaluevpair.Key;
            }
        }

        return -1; // should never happen because majority element always exists
    }
}

/* 
==========================
Approach 2: Sorting Trick
==========================
- If you sort the array, the majority element must occupy the middle index.
- Time: O(n log n), Space: O(1)

public int MajorityElement(int[] nums) {
    Array.Sort(nums);
    return nums[nums.Length / 2];
}

==========================
Approach 3: Boyer–Moore Voting Algorithm
==========================
- Maintain a candidate and a counter.
- Cancel out non-majority elements.
- Time: O(n), Space: O(1)

public int MajorityElement(int[] nums) {
    int candidate = 0;
    int count = 0;

    foreach(int num in nums) {
        if(count == 0) {
            candidate = num;
        }
        count += (num == candidate) ? 1 : -1;
    }

    return candidate;
}

==========================
Approach 4: HashSet (less efficient)
==========================
- Similar to dictionary but only stores unique elements and counts separately.
- Not optimal compared to dictionary or Boyer–Moore.

public int MajorityElement(int[] nums) {
    HashSet<int> set = new HashSet<int>(nums);
    int Dividefactor = nums.Length / 2;

    foreach(int candidate in set) {
        int count = 0;
        foreach(int num in nums) {
            if(num == candidate) count++;
        }
        if(count > Dividefactor) return candidate;
    }

    return -1;
}
*/
