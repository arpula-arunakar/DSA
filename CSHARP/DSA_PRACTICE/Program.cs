// See https://aka.ms/new-console-template for more information
using DSA_PRACTICE.Recursion;


Console.WriteLine("Hello, World!");
var programs = GetPrograms();
Console.WriteLine("Select program to run");
Console.WriteLine("-------------------------------");
foreach (var program in programs)
{
    Console.WriteLine($"{program.Key}. {program.Value}");
}
Console.WriteLine("-------------------------------");
var inputProgram = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(programs[inputProgram]);
var output = inputProgram switch
{
    1 => new SumOfNNumbers().Main(),
    2 => new Factorial().Main(),
    3 => new Power().Main()
};
Console.ReadLine();

static Dictionary<int, string> GetPrograms()
{

    var programs = new Dictionary<int, string>();

    programs.Add(1, "Sum of 'N' Natural Numbers - Recursion");
    programs.Add(2, "Factorial - Recursion");
    programs.Add(3, "Power - Recursion");
    return programs;
}
