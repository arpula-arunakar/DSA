using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_CSHARP.Matrices;
internal class TridiagonalMatrix
{
    //A tridiagonal matrix is a special type of square matrix in which only the elements on the main diagonal, the diagonal just above it, and the diagonal just below it can be non-zero.
    //All other elements must be zero.
    static void ReadMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("Enter matrix elements:");
        Console.WriteLine("Note: Only main, upper, and lower diagonals are allowed to be non-zero.");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(i - j) <= 1) // i==j, i==j-1, i==j+1
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                else
                {
                    matrix[i, j] = 0; 
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("\nTridiagonal Matrix Output:");
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
        ReadMatrix(matrix);
        PrintMatrix(matrix);
        return "";
    }
}
