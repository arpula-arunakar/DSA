using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Search;
internal class BinarySearch
{
    public int BinaryS(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (array[mid] == target)
                return mid;
            else if (target < array[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }
        return -1;
    }
    public int RecursiveBinaryS(int[] array, int left, int right, int target)
    {
        if (left <= right)
        {
            var mid = (left + right) / 2;
            if (array[mid] == target)
                return mid;
            else if (target < array[mid])
                RecursiveBinaryS(array, left, mid - 1, target);
            else
                RecursiveBinaryS(array, mid + 1, right, target);
        }
        return -1;
    }
    public string Main()
    {
        Console.WriteLine($"------------------------------------");
        var array = new int[] { 2, 4, 6, 7, 8, 10, 17, 93 };

        Console.Write($"Enter element to search: ");
        var target = Convert.ToInt32(Console.ReadLine());
        var res = BinaryS(array, target);

        if (res == -1)
            Console.WriteLine($"Item not found");
        else
            Console.WriteLine($"Item found at index {res}");


        return res.ToString();
    }
}
