using DSA_CSHARP.Recursion;
using DSA_CSHARP.Search;

var programs = GetPrograms();
Console.WriteLine("Select the program to run");
Console.WriteLine("-------------------------------");
foreach (var program in programs)
{
    Console.WriteLine($"{program.Key}. {program.Value}");
}
Console.WriteLine("-------------------------------");
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
    _ => "Not Found"
};
Console.ReadLine();

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
    return programs;
}
