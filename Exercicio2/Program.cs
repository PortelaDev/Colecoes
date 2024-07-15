Console.WriteLine("## Exercicio 2 ##\n");


Console.WriteLine("Digite a quantidade de numeros inteiros ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"numeros[{i}] = ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}


string numero;

Console.WriteLine("Digite o numero a ser Procurado ou Fim para parar: ");
numero = Console.ReadLine().ToLower();
do
{

    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);
        if (Array.BinarySearch(numeros, valor) >= 0)
        {
            Console.WriteLine($"seu numero foi achado: {valor}");
        }
        else
        {
            Console.WriteLine("Nao Existe esse numero no array");

        }
    }
    Console.WriteLine("Digite um novo numero ou Fim para parar: ");
    string novoValor = Console.ReadLine().ToLower();
    numero = novoValor;
}
while (numero != "fim");


Console.WriteLine("Fim do processamento...");

Console.ReadKey();
