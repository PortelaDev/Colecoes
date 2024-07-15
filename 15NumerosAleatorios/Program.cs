Console.WriteLine("## Classe Random ##\n");

Random random = new Random();
Console.WriteLine("# Sorteio da MegaSena \n");

int[] numerosSorteados = new int[6];

for (int i = 0; i < numerosSorteados.Length; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);
Console.WriteLine("Numeros Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados));

Console.ReadKey();
