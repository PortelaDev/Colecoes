Console.WriteLine("## METODOS DA CLASSE ARRAY ##\n");

string[] nomes = { "Ana", "Maria", "Marta", "Paula", "Carla", "Beatriz" };

Console.WriteLine("\nExibindo o array original...");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array...");
Console.WriteLine("informe o nome: ");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);
if (indice >= 0)
    Console.WriteLine($"{nome} foi encontrado com indice = {indice}");
else
    Console.WriteLine($"{nome} Nao foi encontrado");

Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($" {nome} ");
    }
}