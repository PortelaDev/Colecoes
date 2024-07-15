using _13List;

Console.WriteLine("## List - Exercicio ##\n");

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };

alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);

var aluno1 = alunos.Find(x => x.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

var listaOrdenada = alunos.OrderBy(x => x.Nome).ToList();

ExibirAlunos(listaOrdenada);

var alunosNota8 = alunos.FindAll(x => x.Nota >= 8);

Console.Write("\nAlunos com nota maior que 8\n");

foreach (var item in alunosNota8)
{
    Console.WriteLine($"{item.Nome}\t{item.Nota}");
}

Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelacao de alunos");
    Console.WriteLine("\nNome\tNota");


    var somaNota = 0.0;
    foreach (var aluno in alunos)
    {
        somaNota += aluno.Nota;
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
    }
    var mediaNotas = somaNota / alunos.Count();
    Console.WriteLine($"\nMedia das Nota: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos: {alunos.Count()}");
}