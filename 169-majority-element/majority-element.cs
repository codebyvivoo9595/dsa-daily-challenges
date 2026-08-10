public class Solution {
    public int MajorityElement(int[] nums) {
    Dictionary <int,int> frq = new  Dictionary<int,int>();
    int Dividefactor = (nums.Length)/2;  
    foreach(int n in nums)
    {
      if(frq.ContainsKey(n))
      {
        frq[n]++;
      }else
      {
        frq[n] = 1;
      }
    }   

   // Find majority element
    foreach(var Keyvaluevpair in frq )
    {
        if(Keyvaluevpair.Value > Dividefactor)
        {
            return Keyvaluevpair.Key;
        }
    }

    return -1;
    }
}