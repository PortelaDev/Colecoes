using System.Collections;

Console.WriteLine("## Array list verificacao ##\n");

var lista = new ArrayList { "Maria", "Ana", "Zilda", "Carlos", "Dina" };

Console.WriteLine("Original");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}

lista.Sort();
Console.WriteLine();
Console.WriteLine("\nArraylist ordenado");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}





Console.ReadKey();