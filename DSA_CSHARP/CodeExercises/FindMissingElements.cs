using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.CodeExercises;
internal class FindMissingElements
{
    void MissingNumbers(int[] array)
    {
        int diff = array[0] - 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] - i != diff)
            {
                while (diff < array[i] - i)
                {
                    Console.WriteLine($"{i + diff}");
                    diff++;
                }
            }
        }
    }
    public string Main()
    {
        var array = new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 };
        MissingNumbers(array);
        return "";
    }
}
