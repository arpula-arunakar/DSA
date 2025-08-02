using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_CSHARP.Matrices;
internal class ToeplitzMatrix
{
    //A Toeplitz matrix(also called a diagonal-constant matrix) is a matrix in which each descending diagonal from left to right is constant.
    //This means that all elements along a diagonal have the same value.

    static void ReadMatrix(int[,] matrix, int n)
    {
        Console.WriteLine("Enter elements for the Toeplitz Matrix:");

        // First row
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Element [0][{j}]: ");
            matrix[0, j] = int.Parse(Console.ReadLine());
        }

        // First column (excluding [0][0])
        for (int i = 1; i < n; i++)
        {
            Console.Write($"Element [{i}][0]: ");
            matrix[i, 0] = int.Parse(Console.ReadLine());
        }

        // Fill remaining values using Toeplitz property
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j - 1];
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        Console.WriteLine("\nToeplitz Matrix Output:");
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

        int[,] matrix = new int[n, n];
        ReadMatrix(matrix, n);
        PrintMatrix(matrix, n);

        return string.Empty;
    }


}
