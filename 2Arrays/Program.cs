Console.WriteLine("## Arrays parte 2 ##\n");
int[] numeros;
numeros = new int[10] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 1010 };
string[] names = { "Ana", "Maria", "Marta", "Paula", "Carla" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"\nElemento de indece {i} : {numeros[i]}");
}

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"\nElemento de indece {i} : {names[i]}");
}



Console.ReadKey();
