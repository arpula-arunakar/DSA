using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class FibanocciSeries
{
    int Fibanocci(int n)
    {
        if (n <= 1) return n;
        return Fibanocci(n - 2) + Fibanocci(n - 1);
    }
    public string Main()
    {
        var res = string.Empty;
        Console.WriteLine($"------------------------------------");

        Console.Write($"Enter 'N': ");
        var n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            res = res + " " + Fibanocci(i);
        }

        Console.WriteLine($"Fibanocci Series : {res}");

        return res.ToString();

    }
}
