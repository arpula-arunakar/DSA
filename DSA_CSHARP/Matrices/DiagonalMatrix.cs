using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Matrices;
internal class DiagonalMatrix
{
    //Diagonal Matrix: A matrix where only the diagonal elements are non-zero, and all other elements are zero.
    static void ReadMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        Console.WriteLine("Enter matrix elements:");
        Console.WriteLine("Note: You need to enter only diagonal elements.....");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                if (i == j)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        Console.WriteLine("\nDiagonal Matrix Output (main diagonal only):");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }
    public string Main()
    {
        Console.Write("Enter the size of the square matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        ReadMatrix(matrix);
        PrintMatrix(matrix);

        return "";
    }
}
