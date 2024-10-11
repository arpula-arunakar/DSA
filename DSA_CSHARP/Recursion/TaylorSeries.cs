using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class TaylorSeries
{
    double p = 1, f = 1, s = 1;
    double e(int x, int n)
    {
        double r;
        if (n == 0) return 1;
        r = e(x, n - 1);
        p = p * x; f = f * n;
        return r + p / f;
    }
    // second version of doing "horner's rule"
    double ev2(int x, int n)
    {
        if (n == 0) return s;
        s = 1 + x * s / n;
        return ev2(x, n - 1);
    }
    //without using recursion
    double eNoRecursion(int x, int n)
    {
        double s = 1, num = 1, den = 1;
        for (int i = 0; i <= n; i++)
        {
            num *= x;
            den *= i;
            s += num / den;
        }
        return s;
    }
    public string Main()
    {
        Console.WriteLine($"------------------------------------");
        Console.Write($"Enter 'x': ");
        var x = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Enter 'N': ");
        var n = Convert.ToInt32(Console.ReadLine());

        var res = ev2(x, n);

        Console.WriteLine($"e^x is: {res}");
        return res.ToString();

    }
}
