using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class Power
{
    public int pow(int m, int n)
    {
        if (n > 0)
            return pow(m, n - 1) * m;
        return 1;
    }
    public string Main()
    {
        Console.WriteLine($"------------------------------------");
        Console.Write($"Enter 'M': ");
        var m = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Enter 'N': ");
        var n = Convert.ToInt32(Console.ReadLine());

        var res = pow(m, n);

        Console.WriteLine($"{m} power {n} is: {res}");
        return res.ToString();

    }
}
