Console.WriteLine("## Metodos FIND do list ## \n");

List<string> frutas = new() { "Uva", "Banana", "Pera", "Maca", "Abacate", "Laranja", "Morango" };

var fruta1 = frutas.Find(x => x.Contains('e'));
var fruta3 = frutas.FindLast(i => i.Contains('n'));
var fruta4 = frutas.FindIndex(i => i.Contains('n'));
var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
var frutas6 = frutas.FindAll(i => i.Contains('n'));


Console.WriteLine(fruta1);
Console.WriteLine(fruta3);
Console.WriteLine(fruta4);
Console.WriteLine(fruta5);

Console.WriteLine("\nFindAll");
foreach (var fruta in frutas6)
{
    Console.Write($"{fruta} ");
}
Console.ReadKey();

