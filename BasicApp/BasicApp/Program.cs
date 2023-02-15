using BasicApp;


Employee emp1 = new Employee("Jan", "Kowalski", 45);
Employee emp2 = new Employee("Michał", "Nowak", 37);
Employee emp3 = new Employee("Anna", "Zawadzka", 42);

List<Employee> listOfStaff = new List<Employee>()
{emp1, emp2, emp3};


//Random rnd = new Random();

//foreach (Employee emp in listOfStaff)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        emp.AddScore(rnd.Next(1, 11));
//    }
//}


emp1.AddScore(1); emp2.AddScore(3); emp3.AddScore(6);
emp1.AddScore(5); emp2.AddScore(2); emp3.AddScore(8);
emp1.AddScore(5); emp2.AddScore(7); emp3.AddScore(6);
emp1.AddScore(4); emp2.AddScore(8); emp3.AddScore(8);
emp1.AddScore(2); emp2.AddScore(4); emp3.AddScore(4);


Employee bestEmp = new Employee("", "", 0);
int record = -1;

foreach (Employee emp in listOfStaff)
{
    int temp = emp.SumScore();
    if (temp > record)
    {
        record = temp;
        bestEmp = emp;
    }
}


Console.WriteLine($"Rekordowa ilość punktów: {bestEmp.name} {bestEmp.surname}, wiek: {bestEmp.age}");
Console.WriteLine($"Ilość punktów wynosi: {bestEmp.SumScore()}");
Console.WriteLine();

Console.WriteLine($"Statystyki dla: {bestEmp.name} {bestEmp.surname}");
var bestEmpStats = bestEmp.GetStatistics();
Console.WriteLine($"Minimalny wynik: {bestEmpStats.MinScore}");
Console.WriteLine($"Maksymalny wynik: {bestEmpStats.MaxScore}");
Console.WriteLine($"Średnia: {bestEmpStats.AverageScore}");
Console.WriteLine();