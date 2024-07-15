string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Digite o nome do aluno na posicao [{i},{j}] :");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\n");
//escrever alunos no console

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i, j]}\t");
    }
    Console.WriteLine();
}