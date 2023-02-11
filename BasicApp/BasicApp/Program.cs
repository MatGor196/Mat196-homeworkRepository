
var number = 11122730000;
var numberAsString = number.ToString();
var tableForNumbers = numberAsString.ToCharArray();
var from0To9 = new int[10];

foreach(var elem in tableForNumbers)
{
    from0To9[ Convert.ToInt32(elem) - 48 ] += 1;
}

Console.WriteLine("Podana liczba: " + number + "\n");
Console.WriteLine("Ilość wystąpień cyfr:");
for (var i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + from0To9[i]);
}

