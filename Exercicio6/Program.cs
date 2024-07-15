Console.WriteLine("## Exercicio 6 ##\n");

/*Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número
variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método
GetType() herdado de Object) no console.
Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)*/



ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);

Console.ReadKey();

static void ProcessaObjetos(params object[] args)
{
    foreach (object obj in args)
    {
        if (obj is null)
        {
            Console.WriteLine($"Valor: null do tipo: null");
        }
        else
        {
            Console.WriteLine($"Valor {obj} do tipo: {obj.GetType()}");

        }
    }

}

public class Teste()
{

}

