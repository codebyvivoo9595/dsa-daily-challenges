public class Solution {
    public bool IsPalindrome(string s) {
      //check the solution   
      int i= 0, j= s.Length-1;

      while(i<j)
      {
         char left = s[i];
         char right =s[j];

         if(!char.IsLetterOrDigit(left))
         {
            i++;
            continue;
         }

         if(!char.IsLetterOrDigit(right))
         {
            j--;
            continue;

         }

         if(char.ToLower(left) != char.ToLower(right))
         {
           return false;
         }

         i++;
         j--;
      }

      return true;

    }
}