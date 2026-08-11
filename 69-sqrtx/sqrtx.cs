public class Solution {
    public int MySqrt(int x) {
    if (x < 2) return x;

    int left = 1, right = x / 2, ans = 0;

    while (left <= right) {
        int mid = left + (right - left) / 2;

        if ((long)mid * mid <= x) {
            ans = mid;       // candidate answer
            left = mid + 1;  // try bigger
        } else {
            right = mid - 1; // try smaller
        }
    }

    return ans;
}

}