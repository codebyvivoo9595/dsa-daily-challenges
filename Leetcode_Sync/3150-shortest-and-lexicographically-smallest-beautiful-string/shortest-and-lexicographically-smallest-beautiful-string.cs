public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int n = s.Length;
        string result = "";
        int minLen = int.MaxValue;

        for (int left = 0; left < n; left++) {
            int ones = 0;
            for (int right = left; right < n; right++) {
                if (s[right] == '1') ones++;
                if (ones == k) {
                    int len = right - left + 1;
                    string candidate = s.Substring(left, len);

                    if (len < minLen || (len == minLen && 
                        (result == "" || string.Compare(candidate, result) < 0))) {
                        minLen = len;
                        result = candidate;
                    }
                    break; // shortest for this left found
                }
            }
        }

        return result;
    }
}
