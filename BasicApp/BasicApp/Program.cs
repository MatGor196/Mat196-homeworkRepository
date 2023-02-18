using BasicApp;

Console.WriteLine("Program oceny pracowników");
Console.WriteLine("-------------------------");

var emp = new EmployeeInFile();

void WriteScoreAddedProcedure(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowy wynik");
}

emp.ScoreAdded += WriteScoreAddedProcedure;

Console.WriteLine("Podaj oceny pracownika (0-100 lub A-E):");
while(true)
{
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        emp.AddScore(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}

Console.WriteLine();
Console.WriteLine("Statystyki pracownika:");
var statistic = emp.GetStatistics();

Console.WriteLine($"Minimaly wynik: {statistic.MinScore}");
Console.WriteLine($"Maksymaly wynik: {statistic.MaxScore}");
Console.WriteLine($"Średni wynik: {statistic.AverageScore:N1}");
Console.WriteLine($"Średni wynik (literowo): {statistic.AverageScoreLetter}");