using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.CodeExercises;
internal class FindDuplicatesInSortedArray
{
    void FindDulicates(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                int j = i + 1;
                while (array[j] == array[i]) j++;
                Console.WriteLine($"{array[i]} is appearing {j - 1} times");
                i = j - 1;
            }
        }
    }
    public string Main()
    {
        var array = new int[] { 3, 6, 8, 8, 10, 12, 15, 15, 15, 15, 20 };
        FindDulicates(array);
        return "";
    }
}
