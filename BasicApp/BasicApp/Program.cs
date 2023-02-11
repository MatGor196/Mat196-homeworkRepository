
string name = "Mat196";
int age = 21;
bool isMan = true;

if (age < 30 && isMan == false)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && isMan == true)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Inna konfiguracja");
}