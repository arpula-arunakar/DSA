using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Matrices;
internal class BandMatrix
{
    //A band matrix is a type of square matrix in which the non-zero elements are confined to a diagonal band — that is, the main diagonal and a fixed number of diagonals above and below it. All other elements are zero.
    void ReadMatrix(int[,] matrix, int k)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine($"Enter elements for band matrix with bandwidth {k}:");

        for (int i = 0; i < n; i++)
        {
            for (int j = Math.Max(0, i - k); j <= Math.Min(n - 1, i + k); j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("\nBand Matrix Output:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public string Main()
    {
        Console.Write("Enter the size of the square matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the bandwidth (k): ");
        int k = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        ReadMatrix(matrix, k);
        PrintMatrix(matrix);

        return "";
    }
}
