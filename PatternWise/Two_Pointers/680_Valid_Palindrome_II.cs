public class Solution {
    //Creating one Helper method 
    public bool CheckPalindrome(int i, int j, string s)
    {
         while(i<j)
         {
            char left = s[i],
            right = s[j];
            if(left != right)
            {
                return false;
            }

            i++;
            j--;
         }
          return true;
    }

    public bool ValidPalindrome(string s) {
        int i = 0,
        j = s.Length-1;

        while(i < j)
        {
            char left = s[i],
            right = s[j];
            if(left != right)
            {
              //We have One condtion we can remove one (remove means skip) abbxa
              // suppose string is bbx
              // string bb correct but bx is not palindrom
              return CheckPalindrome(i+1,j,s) 
              || CheckPalindrome(i,j-1,s);
            }else
            {
                i++;
                j--;
            }
        }

        return true;
    }
}