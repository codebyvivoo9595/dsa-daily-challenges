public class Solution {
    public int LengthOfLastWord(string s) {
      //Hello World
      int i = s.Length - 1;
      int count = 0;
      
      //Removing Trailing Spaces for the give
      while(i >= 0 && s[i] == ' ' )
      {
        i--; // Move to left
      }

     while(i >=0 && s[i] != ' ' )
     {
        count++;
        i--;
     }
     return count;

    }
}