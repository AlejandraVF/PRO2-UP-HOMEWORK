using System;

class Programs
{
    static void Main()
    {
        Console.WriteLine("Ingrese el término de Fibonacci que desea calcular:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Llamada a la función recursiva
        int resultado = CalcularFibonacci(n);

        Console.WriteLine($"El término {n} de la secuencia de Fibonacci es: {resultado}");
    }

    static int CalcularFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            // La secuencia de Fibonacci es la suma de los dos términos anteriores
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}