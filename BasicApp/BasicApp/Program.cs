using BasicApp;

Console.WriteLine("Program oceny pracowników");
Console.WriteLine("-------------------------");
Console.WriteLine();

var emp = new Employee();
Console.WriteLine("Podaj oceny pracownika (0-100 lub A-E):");
while(true)
{
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    emp.AddScore(input);
}

Console.WriteLine();
Console.WriteLine("Statystyki pracownika:");
var statistic = emp.GetStatistics();

Console.WriteLine($"Minimaly wynik: {statistic.MinScore}");
Console.WriteLine($"Maksymaly wynik: {statistic.MaxScore}");
Console.WriteLine($"Średni wynik: {statistic.AverageScore:N2}");
Console.WriteLine($"Średni wynik (literowo): {statistic.AverageScoreLetter}");