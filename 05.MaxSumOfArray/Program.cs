using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("array.txt");
        string line = reader.ReadLine();
        int n = int.Parse(line);
        int[,] matrix = new int[n, n];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            line = reader.ReadLine();
            string[] stringNumbers = line.Split(' ');
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = int.Parse(stringNumbers[cols]);
            }
        }
        reader.Close();
        
        int maxSum = Int32.MinValue;
        maxSum = FindBiggestSum(matrix, maxSum);
        StreamWriter result = new StreamWriter("result.txt");
        result.WriteLine(maxSum);
        result.Close();
    }

    private static int FindBiggestSum(int[,] matrix, int maxSum)
    {
        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
        {
            int sum = 0;
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }
}
