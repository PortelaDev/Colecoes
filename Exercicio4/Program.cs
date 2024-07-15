using System.Collections;
using Exercicio4;

Console.WriteLine("## Exercicio 4 $$\n");
ArrayList lista = new ArrayList();

Console.WriteLine("Digite o nome de 3 pessoas: ");
int total = 3;
for (int i = 0; i < total; i++)
{
    Console.Write($"Digite o {i + 1}o nome:\t");
    string nome = Console.ReadLine();
    Console.Write($"Digite a idade da {i + 1} pessoa:\t");
    int idade = Convert.ToInt32(Console.ReadLine());

    lista.Add(new Pessoa()
    {
        Nome = nome,
        Idade = idade
    });
}

ListaPessoas(lista);

Console.WriteLine("\nAdicionando novas Pessoas: ");
Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa tania = new Pessoa() { Nome = "Tania", Idade = 18 };

lista.Add(jaime);
lista.Add(tania);

ListaPessoas(lista);

Console.WriteLine("\nRemovendo o ultimo da lista");
lista.RemoveAt(lista.Count - 1);
ListaPessoas(lista);



Console.ReadKey();

static void ListaPessoas(ArrayList lista)
{
    Console.WriteLine("\nLista de pesssoas atual...");
    foreach (Pessoa pessoa in lista)
    {
        Console.WriteLine(pessoa.exibir());
    }
}



