
//Approch 1 with Dictonary 
// public class Solution {
//     public int SingleNumber(int[] nums) {
//     //4,1,2,2,1    
//     Dictionary<int,int> frq = new Dictionary<int,int>();
//     //Key Value
//     //4 ==> {4,1},
//     //1 ==>{4,1}, {1,1} 
//     //2==> {4,1}, {1,1} ,{2,1}
//     //2==> {4,1}, {1,1} ,{2,2}
//     //1==> {4,1}, {1,2} ,{2,2}

//     //Count Frequency
//     foreach(int newnum in nums)
//     {
//       if(frq.ContainsKey(newnum))
//       {
//         //Value will update on second occurance
//         frq[newnum]++;
//       }else
//       {
//         //first time 1 will set
//         frq[newnum] = 1;
//       }
//     }


//     foreach(var keyvaluepair in frq)
//     {
//         if(keyvaluepair.Value == 1)
//         {
//             return keyvaluepair.Key;
//         }
//     }


//      return -1;
//     }
// }


//Approch 2 with XOR Operator

public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
     foreach(int num in nums)
     {
        
        result ^= num;
     }
      return result;
    }
}