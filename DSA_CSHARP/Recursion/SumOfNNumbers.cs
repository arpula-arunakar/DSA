using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class SumOfNNumbers
{
    public int SumOfNumbers(int n)
    {

        if (n > 0)
            return SumOfNumbers(n - 1) + n;
        return 0;
    }

    public string Main()
    {
        Console.WriteLine($"------------------------------------");
        Console.Write($"Enter 'N': ");

        var n = Convert.ToInt32(Console.ReadLine());

        var res = SumOfNumbers(n);

        Console.WriteLine($"Sum of {n} numbers is: {res}");
        return res.ToString();

    }
}
