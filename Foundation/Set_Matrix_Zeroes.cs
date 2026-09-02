using System;

class SetMatrixZeroes
{
    static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1,1,1},
            new int[] {1,0,1},
            new int[] {1,1,1}
        };

        int m = matrix.Length;
        int n = matrix[0].Length;

        bool firstRowZero = false;
        bool firstColZero = false;

        // Step 1: Check if first row has zero
        for (int j = 0; j < n; j++)
            if (matrix[0][j] == 0) firstRowZero = true;

        // Step 2: Check if first column has zero
        for (int i = 0; i < m; i++)
            if (matrix[i][0] == 0) firstColZero = true;

        // Step 3: Use first row/col as markers
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        // Step 4: Set cells to zero based on markers
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    matrix[i][j] = 0;
            }
        }

        // Step 5: Handle first row
        if (firstRowZero)
            for (int j = 0; j < n; j++) matrix[0][j] = 0;

        // Step 6: Handle first column
        if (firstColZero)
            for (int i = 0; i < m; i++) matrix[i][0] = 0;

        // Print result
        Console.WriteLine("Final Matrix:");
        foreach (var row in matrix)
            Console.WriteLine(string.Join(",", row));
    }
}
