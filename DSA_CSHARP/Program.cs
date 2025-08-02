using DSA_CSHARP.CodeExercises;
using DSA_CSHARP.Matrices;
using DSA_CSHARP.Recursion;
using DSA_CSHARP.Search;

var programs = GetPrograms();
Console.WriteLine("Select the program to run");
PrintEmptyLine();
foreach (var program in programs)
{
    if (SectionDividingNumbers().Any(x => x == program.Key))
    {
        PrintEmptyLine();
    }
    Console.WriteLine($"{program.Key}. {program.Value}");
}
PrintEmptyLine();
var inputProgram = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(programs.ContainsKey(inputProgram) ? programs[inputProgram] : "Not Found");
var output = inputProgram switch
{
    1 => new SumOfNNumbers().Main(),
    2 => new Factorial().Main(),
    3 => new Power().Main(),
    4 => new TaylorSeries().Main(),
    5 => new FibanocciSeries().Main(),
    6 => new nCr().Main(),
    7 => new TowerOfHanoi().Main(),
    8 => new LinearSearch().Main(),
    9 => new BinarySearch().Main(),
    10 => new FindMissingElement().Main(),
    11 => new FindMissingElements().Main(),
    12 => new FindDuplicatesInSortedArray().Main(),
    13 => new DiagonalMatrix().Main(),
    14 => new LowerTriangularMatrix().Main(),
    15 => new UpperTriangularMatrix().Main(),
    16 => new SymmetricMatrix().Main(),
    17 => new TridiagonalMatrix().Main(),
    18 => new BandMatrix().Main(),
    19 => new ToeplitzMatrix().Main(),
    20 => new SparseMatrix().Main(),
    _ => "Not Found"
};
Console.ReadLine();

static void PrintEmptyLine()
{
    Console.WriteLine("-------------------------------");
}
static List<int> SectionDividingNumbers()
{
    return new List<int>() { 8, 10, 13 };
}

static Dictionary<int, string> GetPrograms()
{

    var programs = new Dictionary<int, string>();

    programs.Add(1, "Sum of 'N' Natural Numbers - Recursion");
    programs.Add(2, "Factorial - Recursion");
    programs.Add(3, "Power - Recursion");
    programs.Add(4, "Taylor Series - Recursion");
    programs.Add(5, "Fibanocci - Recursion");
    programs.Add(6, "nCr - Recursion");
    programs.Add(7, "Tower Of Hanoi - Recursion");
    programs.Add(8, "Linear Search");
    programs.Add(9, "Binary Search");
    programs.Add(10, "Find Missing element(single)");
    programs.Add(11, "Find Missing elements(multiple)");
    programs.Add(12, "Find Duplicates In Sorted Array");
    programs.Add(13, "Diagonal matrix");
    programs.Add(14, "Lower Triangular matrix");
    programs.Add(15, "Upper Triangular matrix");
    programs.Add(16, "Symmetric Matrix");
    programs.Add(17, "Tridiagonal Matrix");
    programs.Add(18, "Band Matrix");
    programs.Add(19, "Toeplitz Matrix");
    programs.Add(20, "Sparse Matrix");
    return programs;
}
