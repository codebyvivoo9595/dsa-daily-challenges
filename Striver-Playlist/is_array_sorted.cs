//Code to check for IS Array Sorted.

public IsArraySorted(int arr[], int n)
{
   for(int i = 0; i <= arr.Length -1 ; i++)
   {
     if(arr[i+1] > arr[i] )
     {
        //Will Not return Any thing but we can traverse till last
     }else
     {
        return false;
     }
   }
   return true;
}