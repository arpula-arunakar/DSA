using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSHARP.Recursion;
internal class TowerOfHanoi
{
    void TOH(int n,int A,int B,int C)
    {
        if (n > 0)
        {
            TOH(n-1,A,C,B);
            Console.WriteLine($"({A},{C})");
            TOH(n - 1, B, A, C);
        }
    }
    public string Main()
    {
        TOH(3,1,2,3);

        return "";
    }
}
