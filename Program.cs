class Program
{
    static void Main() //ejercicio 1
    {
        int[] numeros = { 5, 2, 8, 1, 9, 4, 3 };

        var resultado = ArrayEnteros.EncontrarMaxMin(numeros);

        Console.WriteLine($"Máximo: {resultado.maximo}");
        Console.WriteLine($"Mínimo: {resultado.minimo}");
    }
}