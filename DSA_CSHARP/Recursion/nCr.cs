using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class nCr
{
    public int Fact(int n)
    {
        if (n > 0)
            return Fact(n - 1) * n;
        return 1;
    }
    public int nCrV1(int n, int r)
    {
        int den, num;
        num = Fact(n);
        den = Fact(r) * Fact(n - r);

        return num / den;
    }
    public int nCrV2(int n, int r)
    {
        if (n == r || r == 0) return 1;
        return nCrV2(n - 1, r - 1) + nCrV2(n - 1, r);
    }
    public string Main()
    {
        Console.WriteLine($"------------------------------------");

        Console.Write($"Enter 'N': ");
        var n = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter 'r': ");
        var r = Convert.ToInt32(Console.ReadLine());

        var res = nCrV2(n, r);

        Console.WriteLine($"Value of {n}C{r} is: {res}");
        return res.ToString();

    }
}
