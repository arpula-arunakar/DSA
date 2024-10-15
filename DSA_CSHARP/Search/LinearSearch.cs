using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Search;
internal class LinearSearch
{
    public int Linear(int[] array, int n)
    {

        for (int i = 0; i < n; i++)
        {
            if (array[i] == n)
                return i;
        }
        return -1;
    }
    public string Main()
    {
        Console.WriteLine($"------------------------------------");
        var array = new int[] { 6, 2, 7, 4, 8, 10 };

        Console.Write($"Enter element to search: ");
        var n = Convert.ToInt32(Console.ReadLine());
        var res = Linear(array, n);

        if (res == -1)
            Console.WriteLine($"Item not found");
        else
            Console.WriteLine($"Item found at index {res}");


        return res.ToString();
    }
}
