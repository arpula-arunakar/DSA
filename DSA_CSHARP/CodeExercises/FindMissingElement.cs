using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.CodeExercises;
public class FindMissingElement
{
    int MissingInFirstNNumbers(int[] array)
    {
        int sum = 0, s = 0, n = array[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        s = n * (n + 1) / 2;
        return s - sum;
    }
    public string Main()
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

        var res = MissingInFirstNNumbers(array);
        Console.WriteLine($"Missing element is: {res}");

        return res.ToString();
    }
}
