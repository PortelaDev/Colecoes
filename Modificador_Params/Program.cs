Console.WriteLine("## Soma de numeros inteiros ##\n");

var resultado2 = Calcular.Soma(10, 20, 2.2);
Console.WriteLine(resultado2);

Console.ReadKey();

public class Calcular
{
    //o params tem que estar por ultimo!
    public static double Soma(params double[] numeros)
    {
        double total = 0;
        foreach (double numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}