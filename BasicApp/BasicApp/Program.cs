using BasicApp;

Employee emp1 = new Employee("Jan", "Kowalski", 45);
Employee emp2 = new Employee("Michał", "Nowak", 37);
Employee emp3 = new Employee("Anna", "Zawadzka", 42);

List<Employee> listOfStaff = new List<Employee>()
{emp1, emp2, emp3};

Random rnd = new Random();

foreach (Employee emp in listOfStaff)
{
    for (int i = 0; i < 5; i++)
    {
        emp.AddScore(rnd.Next(1, 11));
    }
}

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

Console.WriteLine("Rekordowa ilość punktów: "
                    + bestEmp.ReturnFullName() + ", wiek: "
                    + bestEmp.age);

Console.WriteLine("Ilość punktów wynosi: " + bestEmp.SumScore());
Console.WriteLine();