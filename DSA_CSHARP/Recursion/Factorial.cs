using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class Factorial
{
    public int FactorialWithN(int n)
    {

        if (n > 0)
            return FactorialWithN(n - 1) * n;
        return 1;
    }
    public string Main()
    {
        Console.WriteLine($"------------------------------------");
        Console.Write($"Enter 'N': ");

        var n = Convert.ToInt32(Console.ReadLine());

        var res = FactorialWithN(n);

        Console.WriteLine($"Factorial of {n} is: {res}");
        return res.ToString();
    }
}
