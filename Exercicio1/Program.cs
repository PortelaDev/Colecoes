Console.WriteLine("Primeira Questao \n");

List<string> frutas = new() { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

Console.WriteLine("Exibicao no laco FOR: \n");

for (int i = 0; i < frutas.Count(); i++)
{
    Console.WriteLine($"indice:\t{i}\tfruta:\t{frutas[i]}");
}
Console.WriteLine($"\nTotal de frutas: {frutas.Count()}");


Console.WriteLine("\nExibicao no laco ForEach: ");
ExibirFrutas(frutas);


Console.WriteLine();
Console.WriteLine($"\nA segunda fruta: {frutas[1]}");
Console.WriteLine($"A penultima fruta: {frutas[8]}");

frutas.RemoveAt(2);
frutas.Insert(2, "Kiwi");
frutas.RemoveAt(9);
frutas.Insert(9, "Caqui");

Console.WriteLine("\nAlteracao: ");
ExibirFrutas(frutas);

frutas.Sort();

Console.WriteLine("\n\nEm Ordem Alfabetica: ");
ExibirFrutas(frutas);

frutas.Reverse();
Console.WriteLine("\n\nEm Ordem Reversa: ");
ExibirFrutas(frutas);


Console.ReadKey();

static void ExibirFrutas(List<string> frutas)
{
    foreach (var fruta in frutas)
    {
        Console.Write($"{fruta} ");
    }
}