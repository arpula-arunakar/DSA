using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Matrices;
internal class UpperTriangularMatrix
{
    // UpperTriangularMatrix: An upper triangular matrix is a square matrix where all the elements below the main diagonal are zero
    static void ReadMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        Console.WriteLine("Enter matrix elements:");
        Console.WriteLine("Note: Enter only the upper triangle (i <= j)");
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        Console.WriteLine("\nUpper Triangular Matrix Output:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }

    public string Main()
    {
        Console.Write("Enter size of the square matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        ReadMatrix(matrix);
        PrintMatrix(matrix);

        return "";
    }
}
