Console.WriteLine("## List seus Principais metodos ## \n ");
var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro", "Ze" };
Exibir(lista);

lista.Sort();

Exibir(lista);

lista.Clear();
Exibir(lista);
Console.WriteLine("Fim");

Console.ReadKey();

static void Exibir(List<string> lista)
{
    Console.WriteLine();
    foreach (var item in lista)
        Console.WriteLine(item);
}