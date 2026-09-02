using System;
using System.Collections.Generic;

class SpiralMatrix
{
    static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };

        List<int> result = new List<int>();

        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            // Traverse top row
            for (int j = left; j <= right; j++)
                result.Add(matrix[top][j]);
            top++;

            // Traverse right column
            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i][right]);
            right--;

            // Traverse bottom row (if still valid)
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    result.Add(matrix[bottom][j]);
                bottom--;
            }

            // Traverse left column (if still valid)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i][left]);
                left++;
            }
        }

        Console.WriteLine("Spiral Order: " + string.Join(",", result));
    }
}
