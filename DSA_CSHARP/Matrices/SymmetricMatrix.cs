using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Matrices;
internal class SymmetricMatrix
{
    //SymmetricMatrix: A symmetric matrix is a square matrix that is equal to its transpose.
    void ReadMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("\n Matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    bool IsSymmetric(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                    return false;
            }
        }
        return true;
    }


    public string Main()
    {
        Console.Write("Enter size of the square matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        ReadMatrix(matrix);
        PrintMatrix(matrix);

        if (IsSymmetric(matrix))
            Console.WriteLine("\n The matrix is symmetric.");
        else
            Console.WriteLine("\n The matrix is NOT symmetric.");

        return "";
    }
}
