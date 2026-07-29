// public class Solution {
//     public int StrStr(string haystack, string needle) {
//         int Occurance = haystack.IndexOf(needle);
//         return Occurance;
//     }
// }


public class Solution {
    public int StrStr(string haystack, string needle) {
        int l1 = haystack.Length;  // length of haystack
        int l2 = needle.Length;    // length of needle

        // loop through haystack, but only until there's enough room left for needle
        for (int i = 0; i <= l1 - l2; i++)
        {
            // quick check: first char matches
            if(haystack[i] == needle[0])
            {
                bool check = true; // assume match until proven otherwise

                // now compare rest of the chars in needle
                for(int j = 1; j < l2; j++){
                    // mismatch found
                    if(haystack[i+j] != needle[j])
                    {
                        check = false;
                        break; // no need to continue inner loop
                    }
                }

                // if all chars matched, return starting index
                if(check) return i;
            }
        }

        // if we finish the loop without finding needle
        return -1;
    }
}
