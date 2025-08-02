using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Matrices;
internal class SparseMatrix
{
    public string Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine($"Enter {rows}x{cols} matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        List<(int row, int col, int value)> sparse = new List<(int, int, int)>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] != 0)
                {
                    sparse.Add((i, j, matrix[i, j]));
                }
            }
        }

        Console.WriteLine("\nSparse Matrix Representation (COO Format):");
        Console.WriteLine("Row\tCol\tValue");
        foreach (var (row, col, value) in sparse)
        {
            Console.WriteLine($"{row}\t{col}\t{value}");
        }

        return "";
    }
}
