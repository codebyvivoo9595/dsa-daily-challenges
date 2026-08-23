public class Solution {
    public int RomanToInt(string s) {
        // map Roman characters to their values
        Dictionary<char, int> romanMap = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;

        // loop through string
        for(int i = 0; i < s.Length; i++) {
            int value = romanMap[s[i]]; // current value

            // check if next value exists and is larger → subtraction case
            if(i + 1 < s.Length && romanMap[s[i+1]] > value) {
                total -= value; // subtract instead of add
            } else {
                total += value; // normal addition
            }

            // debug note: total evolves step by step
        }

        return total;
    }
}
