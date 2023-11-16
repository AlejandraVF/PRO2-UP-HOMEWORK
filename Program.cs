/*EJERCICIO 1 Encontrar el máximo o el mínimo y mostrarlo en la consola de un array de enteros */
class Program
{
    static void Main()
    {
        int[] numeros = { 7, 37, 9, 10, 6, 4, 25 };
        MostrarMaxMinArrayEnteros(numeros);
    }

    public static void MostrarMaxMinArrayEnteros(int[] array)
    {
        int maximo = array[0];
        int minimo = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximo)
            {
                maximo = array[i];
            }

            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }

        Console.WriteLine($"El máximo es: {maximo}");
        Console.WriteLine($"El mínimo es: {minimo}");
    }
}