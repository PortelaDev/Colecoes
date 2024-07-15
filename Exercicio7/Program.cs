using Exercicio7;

Console.WriteLine("## Exercicio 7 ##\n");

Aluno aluno = new Aluno();
aluno[1] = "Caio";
aluno[2] = "Portela";
aluno[4] = "Larisso";
aluno[5] = "Paulo";

string valor1 = aluno[5];
string valor2 = aluno[4];
string valor3 = aluno[1];

Console.WriteLine($"o aluno 5 eh o {valor1}");
Console.WriteLine($"o aluno  {valor2}");
Console.WriteLine($"o aluno  {valor3}");

Console.ReadKey();
