// public class Solution {
//     public int StrStr(string haystack, string needle) {
//         int Occurance = haystack.IndexOf(needle);
//         return Occurance;
//     }
// }


public class Solution {
    public int StrStr(string haystack, string needle) {
        int l1 = haystack.Length;
        int l2 = needle.Length;

        for (int i = 0; i <= l1 - l2; i++)
        {
            if(haystack[i] == needle[0])
            {
                bool check = true;
                for(int j = 1; j < l2; j++){
                    if(haystack[i+j] != needle[j])
                    {
                        check = false;
                        break;
                    }
                }
                if(check) return i;
            }
        }
        return -1;
    }
}