public class Solution {

    // quick helper: checks if substring s[i..j] is a palindrome
    public bool checkPanlindrome(int i, int j, string s)
    {
       while(i < j)
       {
        char left = s[i];   // char at left pointer
        char right = s[j];  // char at right pointer

         if(left != right)  // mismatch found
         {
            return false;   // not a palindrome
         }
         else
         {
            // chars match, move both pointers inward
            i++;
            j--;
         }    
       }
       // loop finished without mismatches
       return true;
    }

    public bool ValidPalindrome(string s) {
     int i = 0;              // start pointer
     int j = s.Length - 1;   // end pointer

         while(i < j)
         {
            char left = s[i];   // current left char
            char right = s[j];  // current right char

            if(left != right)   // mismatch
            {
             // allowed to delete one char
             // option 1: skip left (i+1, j)
             // option 2: skip right (i, j-1)
             return checkPanlindrome(i+1, j, s) || checkPanlindrome(i, j-1, s);
            }
            else
            {
                // chars match, move inward
                i++;
                j--;
            }
         }

         // no mismatches or handled by one deletion
         return true;
    }
}
