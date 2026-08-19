public class Solution {
    public int HammingWeight(int n) {
        int count = 0; // will hold number of 1 bits

        // loop until n becomes 0
        while(n != 0) {
            // check the last bit (n & 1 gives 1 if last bit is set, else 0)
            if((n & 1) == 1) {
                count++; // found a 1 bit
            }

            // debug note: shifting right removes the last bit
            n = n >> 1; // move to next bit
        }

        return count; // total number of 1 bits
    }
}
