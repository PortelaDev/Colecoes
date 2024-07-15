Console.WriteLine("## Exercicio 3 ##\n");

float[,] alunos = new float[2, 5];
float grupo1 = 0.0f;
float grupo2 = 0.0f;

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Informe a nota do grupo {i + 1}");
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"Informe a nota {i,j} = ");
        alunos[i, j] = Convert.ToSingle(Console.ReadLine());
    }
}


for (int i = 0; i < 5; i++)
{
    grupo1 += alunos[0, i];
}

for (int i = 0; i < 5; i++)
{
    grupo2 += alunos[1, i];
}

Console.WriteLine($"A media dos alunos do grupo 2: {grupo2 / 5}");



Console.ReadKey();

