//EJERCICIO 1 
class Program
{
    static void Main()
    {
        // Ejemplo de array de enteros
        int[] numeros = { 7, 3, 9, 1, 6, 4, 5 };

        MostrarMaxMinArrayEnteros(numeros);
    }

    public static void MostrarMaxMinArrayEnteros(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("El array está vacío o es nulo.");
            return;
        }

        int maximo = array[0];
        int minimo = array[0];

        // Encontrar el máximo y el mínimo
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

        // Mostrar resultados en la consola
        Console.WriteLine($"Máximo: {maximo}");
        Console.WriteLine($"Mínimo: {minimo}");
    }
}