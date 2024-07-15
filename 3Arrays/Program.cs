Console.WriteLine("## Arrays parte 3 ##\n");

int[] numeros = { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10 };
string[] nomes = { "Ana", "Maria", "Marta", "Paula", "Carla" };

foreach (int numero in numeros)
{
    Console.Write($" {numero}");
}

foreach (string nome in nomes)
{
    Console.Write($" {nome}");
}

Console.ReadKey();